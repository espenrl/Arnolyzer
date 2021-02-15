﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Arnolyzer.Analyzers.Settings;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SuccincT.Options;

namespace Arnolyzer.Analyzers
{
    internal static class CommonFunctions
    {
        public static string SeverityType(this DiagnosticSeverity severity)
        {
            return Enum.GetName(typeof(DiagnosticSeverity), severity);
        }

        public static bool IsEnabledByDefault(this DefaultState state)
        {
            return state == DefaultState.EnabledByDefault;
        }

        public static bool SkipSymbolAnalysis(ISymbol symbol, SettingsHandler settingsHandler, IEnumerable<Type> suppressionAttributes)
        {
            return HasIgnoreRuleAttribute(symbol, suppressionAttributes) ||
                   SkipSymbolAnalysisIgnoringAttributes(symbol, settingsHandler);
        }

        public static bool SkipSymbolAnalysisIgnoringAttributes(ISymbol symbol, SettingsHandler settingsHandler)
        {
            var settings = settingsHandler.GetArnolyzerSettingsForProject(GetFilePathForSymbol(symbol));
            return AutoGenerated(symbol) || IgnoredFile(symbol, settings);
        }

        private static bool AutoGenerated(ISymbol symbol)
        {
            return SyntaxRootContainsAutoGeneratedComment(symbol.DeclaringSyntaxReferences[0].SyntaxTree.GetRoot());
        }

        public static bool AutoGenerated(SyntaxNode node)
        {
            return SyntaxRootContainsAutoGeneratedComment(node.SyntaxTree.GetRoot());
        }

        private static bool HasIgnoreRuleAttribute(ISymbol symbol, IEnumerable<Type> attributes)
        {
            return symbol.GetAttributes()
                .Any(s => attributes.TryFirst(t => MatchAttributeName(t, s.AttributeClass?.Name)).HasValue);
        }

        public static IEnumerable<NameAndLocation> ItemsToIgnoreFromAttributes(ISymbol symbol, IEnumerable<Type> attributes)
        {
            static IEnumerable<AttributeArgumentSyntax> AttributeArgumentsSelector(AttributeData attribute)
            {
                return (attribute.ApplicationSyntaxReference?.GetSyntax() as AttributeSyntax)?.ArgumentList?.Arguments ?? new SeparatedSyntaxList<AttributeArgumentSyntax>();
            }

            return symbol.GetAttributes()
                .Where(a => attributes.TryFirst(t => MatchAttributeName(t, a.AttributeClass?.Name)).HasValue)
                .SelectMany(AttributeArgumentsSelector)
                .Select(argument => new NameAndLocation(argument.ToString().Trim('"'), argument.GetLocation()));
        }

        public static bool PropertyHasIgnoreRuleAttribute(PropertyDeclarationSyntax property, IEnumerable<Type> attributes)
        {
            return property.AttributeLists
                .SelectMany(l => l.Attributes, (_, a) => a.Name.GetText().ToString())
                .Any(name => attributes.TryFirst(t => MatchAttributeName(t, name)).HasValue);
        }

        private static bool IgnoredFile(ISymbol symbol, SettingsDetails settings)
        {
            return SyntaxTreeIsInIgnoredFile(symbol.DeclaringSyntaxReferences[0].SyntaxTree, settings);
        }

        public static bool IgnoredFile(SyntaxNode node, SettingsDetails settings)
        {
            return SyntaxTreeIsInIgnoredFile(node.SyntaxTree, settings);
        }

        public static bool NodeIsTypeDeclaration(SyntaxNode node)
        {
            var kind = node.Kind();
            return kind == SyntaxKind.ClassDeclaration ||
                   kind == SyntaxKind.InterfaceDeclaration ||
                   kind == SyntaxKind.StructDeclaration ||
                   kind == SyntaxKind.EnumDeclaration;
        }
        private static string GetFilePathForSymbol(ISymbol symbol)
        {
            return symbol.Locations[0].SourceTree!.FilePath;
        }

        private static bool SyntaxRootContainsAutoGeneratedComment(SyntaxNode syntaxRoot)
        {
            return syntaxRoot.ChildNodes()
                             .Where(n => n.HasLeadingTrivia)
                             .Any(node => node.GetLeadingTrivia().Any(t => t.ToString().Contains("<auto-generated>")));
        }

        private static bool MatchAttributeName(Type attributeType, string? name)
        {
            return string.Equals(attributeType.Name.Replace("Attribute", ""), name) ||
                   string.Equals(attributeType.Name, name);
        }

        private static bool SyntaxTreeIsInIgnoredFile(SyntaxTree syntaxTree, SettingsDetails settings)
        {
            return settings.IgnorePathsRegex != "" &&
                   Regex.Match(syntaxTree.FilePath, settings.IgnorePathsRegex).Success;
        }
    }
}