﻿using Arnolyzer.Analyzers.ImmutabilityAnalyzers;
using Arnolyzer.Tests.DiagnosticVerification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuccincT.Options;
using static System.String;

namespace Arnolyzer.Tests.Analyzers.ImmutabilityAnalyzers
{
    [TestClass]
    public class AA1301VariablesShouldBeAssignedOnceOnlyAnalyzerTests
    {
        [TestMethod]
        public void NoCode_ShouldYieldNoDiagnostics() =>
            DiagnosticVerifier.VerifyDiagnostics<AA1301VariablesShouldBeAssignedOnceOnlyAnalyzer>(
                @"..\..\CodeUnderTest\EmptyFile.cs");

        [TestMethod]
        public void IgnoredCode_ShouldYieldNoDiagnostics() =>
            DiagnosticVerifier.VerifyDiagnostics<AA1301VariablesShouldBeAssignedOnceOnlyAnalyzer>(
                @"..\..\CodeUnderTest\CodeToTestVariableReassignment.cs");

        [TestMethod]
        public void InterfacePropertiesWithSetters_YieldsDiagnostics()
        {
            var analyzer = new AA1301VariablesShouldBeAssignedOnceOnlyAnalyzer();
            var analyzerCommonExpected = new DiagnosticResultCommonProperties(analyzer);
            var analyzerSuppressionCommonExpected =
                new DiagnosticResultCommonProperties(analyzer.GetNamedItemSuppresionAttributeDetails()[0]);

            var expected1 =
                new DiagnosticResult(analyzerSuppressionCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseMessageFormat,
                                            "y"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(11, 26, 29)));

            var expected2 =
                new DiagnosticResult(analyzerSuppressionCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseMessageFormat,
                                            "z"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(11, 31, 34)));

            var expected3 =
                new DiagnosticResult(analyzerCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat,
                                            "a"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(16, 13, 18)));

            var expected4 =
                new DiagnosticResult(analyzerCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat,
                                            "b"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(17, 13, 19)));

            var expected5 =
                new DiagnosticResult(analyzerCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat,
                                            "x"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(21, 17, 24)));

            var expected6 =
                new DiagnosticResult(analyzerCommonExpected,
                                     Format(Resources.AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat,
                                            "b"),
                                     Option<DiagnosticLocation>.Some(new DiagnosticLocation(23, 17, 31)));

            DiagnosticVerifier.VerifyDiagnostics<AA1301VariablesShouldBeAssignedOnceOnlyAnalyzer>(
                @"..\..\CodeUnderTest\CodeToTestVariableReassignment.cs",
                expected1,
                expected2,
                expected3,
                expected4,
                expected5,
                expected6);
        }
    }
}