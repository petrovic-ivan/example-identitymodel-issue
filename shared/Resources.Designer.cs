﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shared {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("shared.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///    &quot;keys&quot;: [
        ///        {
        ///            &quot;kty&quot;: &quot;RSA&quot;,
        ///            &quot;e&quot;: &quot;AQAB&quot;,
        ///            &quot;use&quot;: &quot;sig&quot;,
        ///            &quot;kid&quot;: &quot;d0ec514a32b6f88c0abd12a2840699bdd3deba9d&quot;,
        ///            &quot;alg&quot;: &quot;RS256&quot;,
        ///            &quot;n&quot;: &quot;AJSn-hXW9Zzz9ORBKIC9Oi6wzM4zhqwHaKW2vZAqjOeLlpUW7zXwyk4tkivwsydPNaWUm-9oDlEAB2lsQJv7jwWNsF7SGx5R03kenC-cf8Nbxlxwa-Tncjo6uruEsK_Vke244KiSCHP8BOuHI-r5CS0x9edFLgesoYlPPFoJxTs5&quot;
        ///        }
        ///    ]
        ///}.
        /// </summary>
        public static string Jwks {
            get {
                return ResourceManager.GetString("Jwks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to eyJ4NXQiOiJObUptT0dVeE16WmxZak0yWkRSaE5UWmxZVEExWXpkaFpUUmlPV0UwTldJMk0ySm1PVGMxWkEiLCJraWQiOiJkMGVjNTE0YTMyYjZmODhjMGFiZDEyYTI4NDA2OTliZGQzZGViYTlkIiwiYWxnIjoiUlMyNTYifQ.eyJhdF9oYXNoIjoiemdhTWtaNEN6WTcxalRfUTlBTXBnQSIsImFjciI6InVybjptYWNlOmluY29tbW9uOmlhcDpzaWx2ZXIiLCJzdWIiOiJXU08yLk9SR1wvYWRtaW5AY2FyYm9uLnN1cGVyIiwiYXVkIjpbIjlIdTRQMDBJUnVpTHk4S3lidXprZjZuNGttb2EiXSwiYXpwIjoiOUh1NFAwMElSdWlMeThLeWJ1emtmNm40a21vYSIsInJvbGVzIjoiSW50ZXJuYWxcL2V2ZXJ5b25lLFdTTzIuT1JHXC9hZG1pbixBcHBsaWNhdGlvblwvbG9jYWxob3N0U2Vyd [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Jwt {
            get {
                return ResourceManager.GetString("Jwt", resourceCulture);
            }
        }
    }
}
