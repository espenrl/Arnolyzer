﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Arnolyzer.Analyzers.LiskovSubstitutionPrincipleAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class AA2000DoNotUseNotImplementedExceptionAnalyzer : DiagnosticAnalyzer, IAnalyzerDetailsReporter
    {
        private static readonly IList<Type> SuppressionAttributes = new List<Type>();

        private static readonly AnalyzerDetails AA2000Details =
            new AnalyzerDetails(nameof(AA2000DoNotUseNotImplementedExceptionAnalyzer),
                                AnalyzerCategories.LiskovSubstitutionAnalyzers,
                                DefaultState.EnabledByDefault,
                                DiagnosticSeverity.Error,
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionTitle),
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionDescription),
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionMessageFormat),
                                SuppressionAttributes);

        public AnalyzerDetails GetAnalyzerDetails() => AA2000Details;

        private static readonly DiagnosticDescriptor Rule = AA2000Details.GetDiagnosticDescriptor();

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.EnableConcurrentExecution();
            context.RegisterCompilationStartAction(
                compileContext =>
                {
                    var notImplementedExceptionName = compileContext.Compilation.GetTypeByMetadataName("System.NotImplementedException");
                    if (notImplementedExceptionName is null)
                    {
                        throw new Exception($"Could not get type for {nameof(NotImplementedException)}.");
                    }
                    compileContext.RegisterSyntaxNodeAction(
                        symbolContext => LSPViolatingExceptionReporter.ReportLSPViolatingExceptionIfThrown(symbolContext, notImplementedExceptionName, Rule), 
                        SyntaxKind.ThrowStatement);
                });
        }
    }
}