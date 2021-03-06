﻿using System;
using static System.AttributeTargets;
using static System.Environment;

namespace Arnolyzer.RuleExceptionAttributes
{
    // ReSharper disable UnusedParameter.Local
    // ReSharper disable UnusedMember.Local
    // ReSharper disable UnusedMember.Global
    [AttributeUsage(Method|Property)]
    public class MutableVariableAttribute : Attribute, IAttributeDescriber
    {
        public MutableVariableAttribute(string firstMutableVariable, params string[] subsequentMutableVariables) { }
        private MutableVariableAttribute() { }

        public string AttributeDescription =>
            $"A method annotated with {nameof(MutableVariableAttribute)} is allowed to have variables that change value (ie can" +
            $"be reassigned. The variables affected must be named in the {nameof(MutableVariableAttribute)} attribute, eg" +
            $"{NewLine}````cs{NewLine}" +
            $"[{nameof(MutableVariableAttribute)}(\"var1\")]{NewLine}" +
            $"public void F(){NewLine}{{{NewLine}" +
            $"    var var1 = 1;{NewLine}var1 = 2;{NewLine}}}{NewLine}````{NewLine}" +
            $"Multiple variables can be supplied to the attribute, eg [{nameof(MutableVariableAttribute)}(\"var1\", \"var2\")]";
    }
}