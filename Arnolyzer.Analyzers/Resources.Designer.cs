﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arnolyzer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Arnolyzer.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static methods should return a value (must not be null).
        /// </summary>
        public static string AA1000StaticMethodsShouldNotBeVoidDescription {
            get {
                return ResourceManager.GetString("AA1000StaticMethodsShouldNotBeVoidDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static method &apos;{0}&apos; is void. It should return a value.
        /// </summary>
        public static string AA1000StaticMethodsShouldNotBeVoidMessageFormat {
            get {
                return ResourceManager.GetString("AA1000StaticMethodsShouldNotBeVoidMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1000-StaticMethodsShouldNotBeVoid.
        /// </summary>
        public static string AA1000StaticMethodsShouldNotBeVoidTitle {
            get {
                return ResourceManager.GetString("AA1000StaticMethodsShouldNotBeVoidTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static methods should have at least one parameter.
        /// </summary>
        public static string AA1001StaticMethodsShouldHaveAtLeastOneParameterDescription {
            get {
                return ResourceManager.GetString("AA1001StaticMethodsShouldHaveAtLeastOneParameterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static method &apos;{0}&apos; doesn&apos;t have any parameters. It should have at least one.
        /// </summary>
        public static string AA1001StaticMethodsShouldHaveAtLeastOneParameterMessageFormat {
            get {
                return ResourceManager.GetString("AA1001StaticMethodsShouldHaveAtLeastOneParameterMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1001-StaticMethodsShouldHaveAtLeastOneParameter.
        /// </summary>
        public static string AA1001StaticMethodsShouldHaveAtLeastOneParameterTitle {
            get {
                return ResourceManager.GetString("AA1001StaticMethodsShouldHaveAtLeastOneParameterTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A static method should only derive a result from the supplied parameter(s). It should not access any static field or property.
        /// </summary>
        public static string AA1002StaticMethodsShouldNotAccessStateDescription {
            get {
                return ResourceManager.GetString("AA1002StaticMethodsShouldNotAccessStateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to xxx.
        /// </summary>
        public static string AA1002StaticMethodsShouldNotAccessStateMessageFormat {
            get {
                return ResourceManager.GetString("AA1002StaticMethodsShouldNotAccessStateMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1002-StaticMethodsShouldNotAccessState.
        /// </summary>
        public static string AA1002StaticMethodsShouldNotAccessStateTitle {
            get {
                return ResourceManager.GetString("AA1002StaticMethodsShouldNotAccessStateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The only result from calling a static method should be the returned value, or an exception. Therefore it should not invoke any method that has no parameters and/or a void return type, nor write to any field or property..
        /// </summary>
        public static string AA1003StaticMethodsShouldNotCreateStateDescription {
            get {
                return ResourceManager.GetString("AA1003StaticMethodsShouldNotCreateStateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to xxx.
        /// </summary>
        public static string AA1003StaticMethodsShouldNotCreateStateMessageFormat {
            get {
                return ResourceManager.GetString("AA1003StaticMethodsShouldNotCreateStateMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1003-StaticMethodsShouldNotCreateState.
        /// </summary>
        public static string AA1003StaticMethodsShouldNotCreateStateTitle {
            get {
                return ResourceManager.GetString("AA1003StaticMethodsShouldNotCreateStateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To provide encapsulation, properties should only make getters publicly available, so interfaces should not define setters for properties..
        /// </summary>
        public static string AA1100InterfacePropertiesShouldBeReadOnlyDescription {
            get {
                return ResourceManager.GetString("AA1100InterfacePropertiesShouldBeReadOnlyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property `{0}` of interface `{1}` should not define a setter.
        /// </summary>
        public static string AA1100InterfacePropertiesShouldBeReadOnlyMessageFormat {
            get {
                return ResourceManager.GetString("AA1100InterfacePropertiesShouldBeReadOnlyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1100-InterfacePropertiesShouldBeReadOnly.
        /// </summary>
        public static string AA1100InterfacePropertiesShouldBeReadOnlyTitle {
            get {
                return ResourceManager.GetString("AA1100InterfacePropertiesShouldBeReadOnlyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Public classes should not provide publicly accessible setters for properties.
        /// </summary>
        public static string AA1101ClassPropertiesShouldBePubliclyReadOnlyDescription {
            get {
                return ResourceManager.GetString("AA1101ClassPropertiesShouldBePubliclyReadOnlyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Public property `{0}` of class `{1}` should not define a public setter.
        /// </summary>
        public static string AA1101ClassPropertiesShouldBePubliclyReadOnlyMessageFormat {
            get {
                return ResourceManager.GetString("AA1101ClassPropertiesShouldBePubliclyReadOnlyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1101-ClassPropertiesShouldBePubliclyReadOnly.
        /// </summary>
        public static string AA1101ClassPropertiesShouldBePubliclyReadOnlyTitle {
            get {
                return ResourceManager.GetString("AA1101ClassPropertiesShouldBePubliclyReadOnlyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inner types should be treated as implementation details and encapsulated by marking them as private.
        /// </summary>
        public static string AA1102InnerTypesMustBePrivateDescription {
            get {
                return ResourceManager.GetString("AA1102InnerTypesMustBePrivateDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type `{0}` is defined inside another type, so should be made private.
        /// </summary>
        public static string AA1102InnerTypesMustBePrivateMessageFormat {
            get {
                return ResourceManager.GetString("AA1102InnerTypesMustBePrivateMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1102-InnerTypesMustBePrivate.
        /// </summary>
        public static string AA1102InnerTypesMustBePrivateTitle {
            get {
                return ResourceManager.GetString("AA1102InnerTypesMustBePrivateTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static fields introduce global state and so should be avoided.
        /// </summary>
        public static string AA1200AvoidUsingStaticFieldsDescription {
            get {
                return ResourceManager.GetString("AA1200AvoidUsingStaticFieldsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field `{0}` in type `{1}` should not be static.
        /// </summary>
        public static string AA1200AvoidUsingStaticFieldsMessageFormat {
            get {
                return ResourceManager.GetString("AA1200AvoidUsingStaticFieldsMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1200-AvoidUsingStaticFields.
        /// </summary>
        public static string AA1200AvoidUsingStaticFieldsTitle {
            get {
                return ResourceManager.GetString("AA1200AvoidUsingStaticFieldsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static properties introduce global state and so should be avoided.
        /// </summary>
        public static string AA1201AvoidUsingStaticPropertiesDescription {
            get {
                return ResourceManager.GetString("AA1201AvoidUsingStaticPropertiesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property `{0}` in type `{1}` should not be static.
        /// </summary>
        public static string AA1201AvoidUsingStaticPropertiesMessageFormat {
            get {
                return ResourceManager.GetString("AA1201AvoidUsingStaticPropertiesMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1201-AvoidUsingStaticProperties.
        /// </summary>
        public static string AA1201AvoidUsingStaticPropertiesTitle {
            get {
                return ResourceManager.GetString("AA1201AvoidUsingStaticPropertiesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters should be treated as immutable and not used as a mutable variables.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedDescription {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} should be treated as immutable and should not be overwritten.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedMessageFormat {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Items listed in the MutableParameter attribute should exist in the parameter list.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedSuppresionMisuseDescription {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedSuppresionMisuseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} doesn&apos;t exist as a parameter, so shouldn&apos;t be in the attribute.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedSuppresionMisuseMessageFormat {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedSuppresionMisuseMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1300-ParametersShouldNotBeModified.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedSuppresionMisuseTitle {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedSuppresionMisuseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1300-ParametersShouldNotBeModified.
        /// </summary>
        public static string AA1300ParametersShouldNotBeModifiedTitle {
            get {
                return ResourceManager.GetString("AA1300ParametersShouldNotBeModifiedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variables should be treated as immutable and should not be overwritten.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlyDescription {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable {0} should be treated as immutable and should not be overwritten.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variables listed in the MutableVariable attribute should exist in the method body.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseDescription {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable {0} doesn&apos;t exist in the method body, so shouldn&apos;t be in the attribute.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseMessageFormat {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1301-VariablesShouldBeAssignedOnceOnly.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseTitle {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlySuppresionMisuseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA1301-VariablesShouldBeAssignedOnceOnly.
        /// </summary>
        public static string AA1301VariablesShouldBeAssignedOnceOnlyTitle {
            get {
                return ResourceManager.GetString("AA1301VariablesShouldBeAssignedOnceOnlyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NotImplementedException is a direct violation of the Liskov Substitution Principle (LSP) and so must not be used.
        /// </summary>
        public static string AA2000DoNotUseNotImplementedExceptionDescription {
            get {
                return ResourceManager.GetString("AA2000DoNotUseNotImplementedExceptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Throw statement uses the NotImplementedException, which is a violation of the LSP.
        /// </summary>
        public static string AA2000DoNotUseNotImplementedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("AA2000DoNotUseNotImplementedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2000-DoNotUseNotImplementedException.
        /// </summary>
        public static string AA2000DoNotUseNotImplementedExceptionTitle {
            get {
                return ResourceManager.GetString("AA2000DoNotUseNotImplementedExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NotSupportedException is a direct violation of the Liskov Substitution Principle (LSP) and so must not be used.
        /// </summary>
        public static string AA2001DoNotUseNotSupportedExceptionDescription {
            get {
                return ResourceManager.GetString("AA2001DoNotUseNotSupportedExceptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Throw statement uses the NotSupportedException, which is a violation of the LSP.
        /// </summary>
        public static string AA2001DoNotUseNotSupportedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("AA2001DoNotUseNotSupportedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2001-DoNotUseNotSupportedException.
        /// </summary>
        public static string AA2001DoNotUseNotSupportedExceptionTitle {
            get {
                return ResourceManager.GetString("AA2001DoNotUseNotSupportedExceptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method parameters must not use REF or OUT parameters; all results should be via a return.
        /// </summary>
        public static string AA2100MethodParametersMustNotBeRefOrOutDescription {
            get {
                return ResourceManager.GetString("AA2100MethodParametersMustNotBeRefOrOutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter `{0}` of method `{1}` must not use {2}.
        /// </summary>
        public static string AA2100MethodParametersMustNotBeRefOrOutMessageFormat {
            get {
                return ResourceManager.GetString("AA2100MethodParametersMustNotBeRefOrOutMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2100-MethodParametersMustNotBeRefOrOut.
        /// </summary>
        public static string AA2100MethodParametersMustNotBeRefOrOutTitle {
            get {
                return ResourceManager.GetString("AA2100MethodParametersMustNotBeRefOrOutTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A long method is likely to break the single responsibility principle by carrying out unrelated activity.
        /// </summary>
        public static string AA2101MethodTooLongDescription {
            get {
                return ResourceManager.GetString("AA2101MethodTooLongDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to xxxx.
        /// </summary>
        public static string AA2101MethodTooLongMessageFormat {
            get {
                return ResourceManager.GetString("AA2101MethodTooLongMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2101-MethodTooLong.
        /// </summary>
        public static string AA2101MethodTooLongTitle {
            get {
                return ResourceManager.GetString("AA2101MethodTooLongTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An overly long file is likely to contain a type that breaks the single responsibility principle by carrying out unrelated activity.
        /// </summary>
        public static string AA2102FileTooLongDescription {
            get {
                return ResourceManager.GetString("AA2102FileTooLongDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to xxx.
        /// </summary>
        public static string AA2102FileTooLongMessageFormat {
            get {
                return ResourceManager.GetString("AA2102FileTooLongMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2102-FileTooLong.
        /// </summary>
        public static string AA2102FileTooLongTitle {
            get {
                return ResourceManager.GetString("AA2102FileTooLongTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method names that contain &quot;And&quot; often indicate a method is doing more than one thing. Consider refacting into two methods..
        /// </summary>
        public static string AA2103MethodShouldNotContainAndDescription {
            get {
                return ResourceManager.GetString("AA2103MethodShouldNotContainAndDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; contains &quot;And&quot;, which might indicate it&apos;s doing more than one thing.
        /// </summary>
        public static string AA2103MethodShouldNotContainAndMessageFormat {
            get {
                return ResourceManager.GetString("AA2103MethodShouldNotContainAndMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2103-MethodShouldNotContainAnd.
        /// </summary>
        public static string AA2103MethodShouldNotContainAndTitle {
            get {
                return ResourceManager.GetString("AA2103MethodShouldNotContainAndTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To comply with the single responsibility principle, a file should only contain one non-private type definition..
        /// </summary>
        public static string AA2104FileMustOnlyContainOneTypeDefinitionDescription {
            get {
                return ResourceManager.GetString("AA2104FileMustOnlyContainOneTypeDefinitionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type `{0}` is located in a file that contains other type definitions.
        /// </summary>
        public static string AA2104FileMustOnlyContainOneTypeDefinitionMessageFormat {
            get {
                return ResourceManager.GetString("AA2104FileMustOnlyContainOneTypeDefinitionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AA2104-FileMustOnlyContainOneTypeDefinition.
        /// </summary>
        public static string AA2104FileMustOnlyContainOneTypeDefinitionTitle {
            get {
                return ResourceManager.GetString("AA2104FileMustOnlyContainOneTypeDefinitionTitle", resourceCulture);
            }
        }
    }
}
