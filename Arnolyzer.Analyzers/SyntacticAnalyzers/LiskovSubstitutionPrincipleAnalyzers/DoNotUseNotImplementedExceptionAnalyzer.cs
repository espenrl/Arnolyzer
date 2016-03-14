﻿using System.Collections.Immutable;
using Arnolyzer.SyntacticAnalyzers.Factories;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using static Arnolyzer.SyntacticAnalyzers.LiskovSubstitutionPrincipleAnalyzers.LSPViolatingExceptionReporter;

namespace Arnolyzer.SyntacticAnalyzers.LiskovSubstitutionPrincipleAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DoNotUseNotImplementedExceptionAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "DoNotUseNotImplementedException";

        private static readonly LocalizableString Title =
            LocalizableStringFactory.LocalizableResourceString(nameof(Resources.DoNotUseNotImplementedExceptionTitle));

        private static readonly LocalizableString MessageFormat =
            LocalizableStringFactory.LocalizableResourceString(nameof(Resources.DoNotUseNotImplementedExceptionMessageFormat));

        private static readonly LocalizableString Description =
            LocalizableStringFactory.LocalizableResourceString(nameof(Resources.DoNotUseNotImplementedExceptionDescription));

        private static readonly DiagnosticDescriptor Rule =
            DiagnosticDescriptorFactory.EnabledByDefaultErrorDescriptor(AnalyzerCategories.EncapsulationAnalyzers,
                                                                        DiagnosticId,
                                                                        Title,
                                                                        MessageFormat,
                                                                        Description);

        

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterCompilationStartAction(
                compileContext =>
                {
                    var notImplementedExceptionName = compileContext.Compilation.GetTypeByMetadataName("System.NotImplementedException");
                    compileContext.RegisterSyntaxNodeAction(
                        symbolContext => DetectAndReportLSPViolatingException(symbolContext, notImplementedExceptionName, Rule), 
                        SyntaxKind.ThrowStatement);
                });
        }
    }
}