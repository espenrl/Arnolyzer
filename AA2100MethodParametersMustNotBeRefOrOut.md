---
title: Arnolyzer - AA2100 - Method Parameters Must Not Be Ref Or Out
layout: default
---
# AA2100 - Method Parameters Must Not Be Ref Or Out #
**Report code: AA2100-MethodParametersMustNotBeRefOrOut**

## Summary ##
<table>
<tr>
  <td><strong>Status</strong></td>
  <td>Implemented</td>
</tr>
<tr>
  <td><strong>Description</strong></td>
  <td>Method parameters must not use REF or OUT parameters; all results should be via a return</td>
</tr>
<tr>
  <td><strong>Category</strong></td>
  <td><a href="SingleResponsibiltyAnalyzers.html">Single Responsibilty Analyzers</a></td>
</tr>
<tr>
  <td><strong>Enabled by default:</strong></td>
  <td>Yes</td>
</tr>
<tr>
  <td><strong>Severity:</strong></td>
  <td>Error</td>
</tr>
</table>

## Cause ##

`out` parameters are normally used to return a second value from a method, which in turn is often a sign that the method is
doing more than one thing and thus is breaking the Single Responsibility Principle.

## How to fix violations ##

There currently aren't any implemented code-fixes for this rule.

## How to suppress violations ##

This rule cannot be suppressed.