﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MHG.Sample.Localizer.Resx {
    using System;
    using System.Reflection;
    
    
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
    internal class Lang {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Lang() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MHG.Sample.Localizer.Resx.Lang", typeof(Lang).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Tamam.
        /// </summary>
        internal static string ButtonOk {
            get {
                return ResourceManager.GetString("ButtonOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kaydet.
        /// </summary>
        internal static string ButtonSave {
            get {
                return ResourceManager.GetString("ButtonSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yeni Kullanıcı Kaydı.
        /// </summary>
        internal static string FormName {
            get {
                return ResourceManager.GetString("FormName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adınız.
        /// </summary>
        internal static string LabelName {
            get {
                return ResourceManager.GetString("LabelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Şifreniz.
        /// </summary>
        internal static string LabelPassword {
            get {
                return ResourceManager.GetString("LabelPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Soyadınız.
        /// </summary>
        internal static string LabelSurname {
            get {
                return ResourceManager.GetString("LabelSurname", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kayıt işlemi gerçekleştirilemedi, Hata: {0}.
        /// </summary>
        internal static string MessageErrorMessage {
            get {
                return ResourceManager.GetString("MessageErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hata.
        /// </summary>
        internal static string MessageErrorTitle {
            get {
                return ResourceManager.GetString("MessageErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kayıt işlemi başarılı.
        /// </summary>
        internal static string MessageSuccessMessage {
            get {
                return ResourceManager.GetString("MessageSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tebrikler!.
        /// </summary>
        internal static string MessageSuccessTitle {
            get {
                return ResourceManager.GetString("MessageSuccessTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Öğrenci Kayıt.
        /// </summary>
        internal static string TitleStudentRegister {
            get {
                return ResourceManager.GetString("TitleStudentRegister", resourceCulture);
            }
        }
    }
}