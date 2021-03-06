﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Live {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Live.Internal.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Another async operation is already in progress..
        /// </summary>
        internal static string AsyncOperationInProgress {
            get {
                return ResourceManager.GetString("AsyncOperationInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while adding the request to the BackgroundTransferService..
        /// </summary>
        internal static string BackgroundTransferServiceAddError {
            get {
                return ResourceManager.GetString("BackgroundTransferServiceAddError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while removing a request to the BackgroundTransferService..
        /// </summary>
        internal static string BackgroundTransferServiceRemoveError {
            get {
                return ResourceManager.GetString("BackgroundTransferServiceRemoveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while reading the response of the BackgroundUpload..
        /// </summary>
        internal static string BackgroundUploadResponseHandlerError {
            get {
                return ResourceManager.GetString("BackgroundUploadResponseHandlerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A connection to the server could not be established..
        /// </summary>
        internal static string ConnectionError {
            get {
                return ResourceManager.GetString("ConnectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User has not granted the application consent to access data in Windows Live..
        /// </summary>
        internal static string ConsentNotGranted {
            get {
                return ResourceManager.GetString("ConsentNotGranted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string FileNameInvalid {
            get {
                return ResourceManager.GetString("FileNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  &apos;{0}&apos; cannot be null or empty..
        /// </summary>
        internal static string InvalidNullOrEmptyParameter {
            get {
                return ResourceManager.GetString("InvalidNullOrEmptyParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  &apos;{0}&apos; cannot be null..
        /// </summary>
        internal static string InvalidNullParameter {
            get {
                return ResourceManager.GetString("InvalidNullParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The login page is already open..
        /// </summary>
        internal static string LoginPopupAlreadyOpen {
            get {
                return ResourceManager.GetString("LoginPopupAlreadyOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; must be called from the application&apos;s UI thread..
        /// </summary>
        internal static string NotOnUiThread {
            get {
                return ResourceManager.GetString("NotOnUiThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine the upload location.  Make sure the path points to a file resource id..
        /// </summary>
        internal static string NoUploadLinkFound {
            get {
                return ResourceManager.GetString("NoUploadLinkFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  &apos;{0}&apos; must be a relative url..
        /// </summary>
        internal static string RelativeUrlRequired {
            get {
                return ResourceManager.GetString("RelativeUrlRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not invoke the login page before the application root visual is rendered..
        /// </summary>
        internal static string RootVisualNotRendered {
            get {
                return ResourceManager.GetString("RootVisualNotRendered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while performing the operation. Please try again later..
        /// </summary>
        internal static string ServerError {
            get {
                return ResourceManager.GetString("ServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while performing the operation. Server returned a response with status {0}..
        /// </summary>
        internal static string ServerErrorWithStatus {
            get {
                return ResourceManager.GetString("ServerErrorWithStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  Stream is not readable..
        /// </summary>
        internal static string StreamNotReadable {
            get {
                return ResourceManager.GetString("StreamNotReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  Stream is not writable..
        /// </summary>
        internal static string StreamNotWritable {
            get {
                return ResourceManager.GetString("StreamNotWritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid. &apos;{0}&apos; must contain a filename..
        /// </summary>
        internal static string UriMissingFileName {
            get {
                return ResourceManager.GetString("UriMissingFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid. &apos;{0}&apos; must be rooted in \shared\transfers..
        /// </summary>
        internal static string UriMustBeRootedInSharedTransfers {
            get {
                return ResourceManager.GetString("UriMustBeRootedInSharedTransfers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input parameter &apos;{0}&apos; is invalid.  &apos;{0}&apos; must be a valid URI..
        /// </summary>
        internal static string UrlInvalid {
            get {
                return ResourceManager.GetString("UrlInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User did not log in.  Call LiveAuthClient.LoginAsync to log in..
        /// </summary>
        internal static string UserNotLoggedIn {
            get {
                return ResourceManager.GetString("UserNotLoggedIn", resourceCulture);
            }
        }
    }
}
