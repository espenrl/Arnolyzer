﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Arnolyzer;
using Arnolyzer.Analyzers;
using Arnolyzer.RuleExceptionAttributes;
using static System.Environment;
using static ArnolyzerDocumentationGenerator.AnalyzerDetailsGenerator;

namespace ArnolyzerDocumentationGenerator
{
    public static class ArnolyzerDocumentationGenerator
    {
        private static void Main()
        {
            var implementedAnalyzersDetails = GetDetailsOfImplementedAnalyzers();
            var plannedAnalyzerDetails = GetDetailsOfPlannedAnalyzers();
            GenerateImplementedAnalyzerDocuments(implementedAnalyzersDetails);
            GenerateReadMe(implementedAnalyzersDetails, plannedAnalyzerDetails);
        }

        private static  void GenerateImplementedAnalyzerDocuments(IEnumerable<AnalyzerDetails> analyzersDetails)
        {
            var template = File.ReadAllText(@"..\..\..\Arnolyzer.Analyzers\DocumentationTemplates\AnalyzerTemplate.md");
            foreach (var details in analyzersDetails)
            {
                var analyzerName = details.DiagnosticId;
                Console.WriteLine($"Generating {analyzerName}.md");

                var extraWords = CreateExtraWordsSet(analyzerName);
                var processedContents = ProcessAnalyzerTemplateText(template, details, extraWords);

                File.WriteAllText($@"..\..\..\..\Arnolyzer.wiki\{analyzerName}.md",
                                  processedContents);
            }
        }

        private static void GenerateReadMe(IEnumerable<AnalyzerDetails> implementedAnalyzersDetails,
                                           IEnumerable<AnalyzerDetails> plannedAnalyzerDetails)
        {
            var template = File.ReadAllText(@"..\..\..\Arnolyzer.Analyzers\DocumentationTemplates\README-template.md");
            File.WriteAllText(@"..\..\..\README.md", 
                              ProcessGeneralTemplateText(template, implementedAnalyzersDetails, plannedAnalyzerDetails));
        }

        private static string ProcessAnalyzerTemplateText(string template, AnalyzerDetails details, ExtraWordsContents extraWords) => 
            template.Replace(" % NAME%", details.Name)
                    .Replace("%CODE%", details.Title.ToString())
                    .Replace("%ID%", details.DiagnosticId)
                    .Replace("%DESCRIPTION%", details.Description.ToString())
                    .Replace("%CATEGORY%", details.Category.Name)
                    .Replace("%SEVERITY%", details.SeverityText)
                    .Replace("%ENABLED-BY_DEFAULT%", details.EnabledByDefault ? "Yes" : "No")
                    .Replace("%CAUSE-WORDS%", extraWords.Cause)
                    .Replace("%PRE-CODEFIX-WORDS%", extraWords.PreCodeFix)
                    .Replace("%POST-CODEFIX-WORDS%", extraWords.PostCodeFix)
                    .Replace("%PRE-SUPPRESSION-WORDS%", extraWords.PreSuppression)
                    .Replace("%POST-SUPPRESSION-WORDS%", extraWords.PostSuppression)
                    .Replace("%CODEFIXES%", "There currently aren't any implemented code-fixes for this rule.")
                    .Replace("%SUPPRESSIONS%", GenerateSuppressionMessages(details.SuppressionAttributes));

        private static string ProcessGeneralTemplateText(string template, 
                                                         IEnumerable<AnalyzerDetails> implementedAnalyzersDetails,
                                                         IEnumerable<AnalyzerDetails> plannedAnalyzerDetails) =>
            template.Replace("%DATE%", DateTime.Now.ToString("dd MMM yyyy"))
                    .Replace("%CURRENT-VERSION%", ArnolyzerVersion.Version)
                    .Replace("%CURRENT-RELEASE-NOTES%", GenerateReleaseDetails(ArnolyzerVersion.Version))
                    .Replace("%IMPLEMENTED-LIST%", GenerateAnalyzerList(implementedAnalyzersDetails))
                    .Replace("%PLANNED-LIST%", GenerateAnalyzerList(plannedAnalyzerDetails))
                    .Replace("%CATEGORY-LIST%", "<<--- CATEGORY-LIST --->>")
                    .Replace("%PREVIOUS-RELEASE-NOTES%", "<<--- PREVIOUS-RELEASE-NOTES --->>");

        private static ExtraWordsContents CreateExtraWordsSet(string analyzerName) => 
            new ExtraWordsContents(FileContentsIfExists($"{analyzerName}.cause.txt"),
                                    FileContentsIfExists($"{analyzerName}.preCodeFix.txt"),
                                    FileContentsIfExists($"{analyzerName}.postCodeFix.txt"),
                                    FileContentsIfExists($"{analyzerName}.preSuppression.txt"),
                                    FileContentsIfExists($"{analyzerName}.postSuppression.txt"));

        private static string FileContentsIfExists(string fileName)
        {
            try
            {
                return File.ReadAllText($@"..\..\..\Arnolyzer.Analyzers\DocumentationTemplates\{fileName}");
            }
            catch (FileNotFoundException)
            {
                if (fileName.Contains("cause"))
                {
                    Console.WriteLine($"-----> {fileName} not found.");
                }
                return "";
            }
        }

        private static string GenerateSuppressionMessages(IList<Type> suppressionAttributes) => 
            suppressionAttributes.Any()
                ? $"This rule can be suppressed using the following attributes: {DescribeEachAttribute(suppressionAttributes)}"
                : "This rule cannot be suppressed.";

        private static string DescribeEachAttribute(IEnumerable<Type> suppressionAttributes) => 
            suppressionAttributes.Aggregate("", (previous, attribute) => $"{previous}{NewLine}{NewLine}{FormatAttribute(attribute)}");

        private static string FormatAttribute(Type attribute)
        {
            var instance = (IAttributeDescriber) Activator.CreateInstance(attribute);
            var name = attribute.Name.Replace("Attribute", "");
            var description = instance.AttributeDescription.Replace("Attribute", " attribute");
            return $"**[{name}]**{NewLine}{description}";
        }

        private static string GenerateReleaseDetails(string version) =>
            File.ReadAllText($@"..\..\..\Arnolyzer.Analyzers\ReleaseNotes\Release.{version}.md");

        private static string GenerateAnalyzerList(IEnumerable<AnalyzerDetails> analyzersDetails)
        {
            var builder = new StringBuilder();
            foreach (var analyzerGroup in from analyzer in analyzersDetails
                                          group analyzer by analyzer.Category into g
                                          orderby g.Key.Code select g)
            {
                builder.Append($"**{analyzerGroup.Key.Name}**{NewLine}");
                foreach (var analyzer in analyzerGroup.OrderBy(a => a.NameAndCode))
                {
                    builder.Append(CreateAnalyzerLink(analyzer));
                }
                builder.Append(NewLine);
            }

            return builder.ToString();
        }

        private static string CreateAnalyzerLink(AnalyzerDetails analyzer) =>
            $"[{analyzer.NameAndCode}](https://github.com/DavidArno/Arnolyzer/wiki/{analyzer.DiagnosticId}.md){NewLine}";
    }
}
