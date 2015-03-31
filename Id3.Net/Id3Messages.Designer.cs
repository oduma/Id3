﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Id3 {
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
    internal class Id3Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Id3Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Id3.Id3Messages", typeof(Id3Messages).Assembly);
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
        ///   Looks up a localized string similar to Audio stream not found in this MP3 file.
        /// </summary>
        internal static string AudioStreamMissing {
            get {
                return ResourceManager.GetString("AudioStreamMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The tag should specify a major version number.
        /// </summary>
        internal static string MajorTagVersionMissing {
            get {
                return ResourceManager.GetString("MajorTagVersionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete the tag; MP3 stream does not have write permissions.
        ///You will need to create the {0} instance with write permissions..
        /// </summary>
        internal static string NoWritePermissions_CannotDeleteTag {
            get {
                return ResourceManager.GetString("NoWritePermissions_CannotDeleteTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write the tag; MP3 stream does not have write permissions.
        ///You will need to create the {0} instance with write permissions..
        /// </summary>
        internal static string NoWritePermissions_CannotWriteTag {
            get {
                return ResourceManager.GetString("NoWritePermissions_CannotWriteTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MP3 stream should be readable and seekable.
        /// </summary>
        internal static string StreamNotReadableOrSeekable {
            get {
                return ResourceManager.GetString("StreamNotReadableOrSeekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MP3 stream should be writable.
        /// </summary>
        internal static string StreamNotWritable {
            get {
                return ResourceManager.GetString("StreamNotWritable", resourceCulture);
            }
        }
    }
}