using System.Linq;
using Arnolyzer.RuleExceptionAttributes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using SuccincT.Options;
using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;

namespace Arnolyzer.Analyzers.LiskovSubstitutionPrincipleAnalyzers
{
    internal static class LSPViolatingExceptionReporter
    {
        [HasSideEffects]
        public static void ReportLSPViolatingExceptionIfThrown(SyntaxNodeAnalysisContext context,
                                                               INamedTypeSymbol exceptionType,
                                                               DiagnosticDescriptor rule)
        {
            if (context.Node is not ThrowStatementSyntax throwStatement || throwStatement.Expression is null)
            {
                return;
            }

            throwStatement.Expression.DescendantNodesAndTokens()
                          .Where(t => t.IsKind(SyntaxKind.IdentifierName) || t.IsKind(SyntaxKind.IdentifierToken))
                          .TryFirst()
                          .Match()
                          .Some().Where(t => t.IsNode).Do(t =>
                          {
                              if (t.AsNode() is IdentifierNameSyntax identifier)
                              {
                                  var identifierType = context.SemanticModel.GetSymbolInfo(identifier);
                                  if (SymbolEqualityComparer.Default.Equals(identifierType.Symbol, exceptionType))
                                  {
                                      context.ReportDiagnostic(Diagnostic.Create(rule, identifier.GetLocation()));
                                  }
                              }
                          })
                          .Some().Do(t =>
                          {
                              if (t.Parent is IdentifierNameSyntax identifier)
                              {
                                  var identiferType = context.SemanticModel.GetTypeInfo(identifier).Type;
                                  if (SymbolEqualityComparer.Default.Equals(identiferType, exceptionType))
                                  {
                                      context.ReportDiagnostic(Diagnostic.Create(rule, identifier.GetLocation()));
                                  }
                              }
                          })
                          .None().Do(() => { })
                          .Exec();
        }
    }
}
