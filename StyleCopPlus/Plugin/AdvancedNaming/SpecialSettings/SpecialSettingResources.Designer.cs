﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StyleCopPlus.Plugin.AdvancedNaming {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SpecialSettingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SpecialSettingResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StyleCopPlus.Plugin.AdvancedNaming.SpecialSettings.SpecialSettingResources", typeof(SpecialSettingResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a list of naming abbreviations, that should be considered
        ///as separate words in $(AaBb), $(aaBb) and $(Aa_Bb) macros.
        ///Use UPPERCASE letters and digits, separating them by whitespaces..
        /// </summary>
        internal static string AbbreviationsHelp {
            get {
                return ResourceManager.GetString("AbbreviationsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems that your abbreviations string has wrong syntax.
        ///
        ///Please check that:
        ///- string literals don&apos;t contain any characters except UPPERCASE letters and digits
        ///- string literals are separated by whitespaces.
        /// </summary>
        internal static string AbbreviationsWarning {
            get {
                return ResourceManager.GetString("AbbreviationsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a list of names which should be ignored
        ///when prohibiting too short names (less than 4 characters).
        ///Use letters, digits and underscore, separating them by whitespaces..
        /// </summary>
        internal static string CheckLengthExceptionsHelp {
            get {
                return ResourceManager.GetString("CheckLengthExceptionsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems that your exceptions string has wrong syntax.
        ///
        ///Please check that:
        ///- string literals don&apos;t contain any characters except letters, digits and underscore
        ///- string literals are separated by whitespaces.
        /// </summary>
        internal static string CheckLengthExceptionsWarning {
            get {
                return ResourceManager.GetString("CheckLengthExceptionsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ...{0}.
        /// </summary>
        internal static string DerivingsExample {
            get {
                return ResourceManager.GetString("DerivingsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Derived class.
        /// </summary>
        internal static string DerivingsFriendlyName {
            get {
                return ResourceManager.GetString("DerivingsFriendlyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a list of classes, whose names should always
        ///be added to the end of the name for derived class.
        ///Use letters, digits and underscore, separating them by whitespaces..
        /// </summary>
        internal static string DerivingsHelp {
            get {
                return ResourceManager.GetString("DerivingsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems that your derivings string has wrong syntax.
        ///
        ///Please check that:
        ///- string literals don&apos;t contain any characters except letters, digits and underscore
        ///- string literals are separated by whitespaces.
        /// </summary>
        internal static string DerivingsWarning {
            get {
                return ResourceManager.GetString("DerivingsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit &quot;{0}&quot; Setting.
        /// </summary>
        internal static string EditorCaption {
            get {
                return ResourceManager.GetString("EditorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a list of complex words, that should be considered
        ///as one word in $(AaBb), $(aaBb) and $(Aa_Bb) macros.
        ///Use letters and digits, separating them by whitespaces..
        /// </summary>
        internal static string WordsHelp {
            get {
                return ResourceManager.GetString("WordsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems that your words string has wrong syntax.
        ///
        ///Please check that:
        ///- string literals don&apos;t contain any characters except letters and digits
        ///- string literals are separated by whitespaces.
        /// </summary>
        internal static string WordsWarning {
            get {
                return ResourceManager.GetString("WordsWarning", resourceCulture);
            }
        }
    }
}
