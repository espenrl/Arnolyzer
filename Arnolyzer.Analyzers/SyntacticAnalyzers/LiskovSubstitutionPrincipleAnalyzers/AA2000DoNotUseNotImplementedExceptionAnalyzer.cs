﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using static Arnolyzer.SyntacticAnalyzers.DefaultState;
using static Arnolyzer.SyntacticAnalyzers.LiskovSubstitutionPrincipleAnalyzers.LSPViolatingExceptionReporter;
using static Microsoft.CodeAnalysis.DiagnosticSeverity;

namespace Arnolyzer.SyntacticAnalyzers.LiskovSubstitutionPrincipleAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class AA2000DoNotUseNotImplementedExceptionAnalyzer : DiagnosticAnalyzer, IAnalyzerDetailsReporter
    {
        private static readonly IList<Type> SuppressionAttributes = new List<Type>();

        private static readonly AnalyzerDetails AA2000Details =
            new AnalyzerDetails(nameof(AA2000DoNotUseNotImplementedExceptionAnalyzer),
                                AnalyzerCategories.EncapsulationAndImmutabilityAnalyzers,
                                EnabledByDefault,
                                Error,
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionTitle),
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionDescription),
                                nameof(Resources.AA2000DoNotUseNotImplementedExceptionMessageFormat),
                                SuppressionAttributes);

        public AnalyzerDetails GetAnalyzerDetails() => AA2000Details;

        private static readonly DiagnosticDescriptor Rule = AA2000Details.GetDiagnosticDescriptor();

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