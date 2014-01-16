﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NL.Server.Configuration {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NL.Server.Configuration.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to CLS;Clears the console of all text with exception of the command line.;DISABLECL;Removes and disables the command line from the console.
        ///It is not possible to re-enable the command line after this command has been 
        ///executed without restarting the console.;DCIP &lt;TARGET IP&gt;;Closes all connections with the target IP address from all servers.;DCSERVER &lt;TARGET SERVER PORT&gt;;Closes all connections from the target server server.
        ///Blocks it from accepting any further connections.;RCSERVER &lt;TARGET SERVER PORT&gt;;Reco [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CommandHelp {
            get {
                return ResourceManager.GetString("CommandHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Online.
        /// </summary>
        internal static string Connected {
            get {
                return ResourceManager.GetString("Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controller does not exist..
        /// </summary>
        internal static string ControllerDoesNotExist {
            get {
                return ResourceManager.GetString("ControllerDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offline.
        /// </summary>
        internal static string Disconnected {
            get {
                return ResourceManager.GetString("Disconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;help&apos; for a list of available commands..
        /// </summary>
        internal static string HelpPrompt {
            get {
                return ResourceManager.GetString("HelpPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid IP address given..
        /// </summary>
        internal static string InvIPAddress {
            get {
                return ResourceManager.GetString("InvIPAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number of arguments..
        /// </summary>
        internal static string InvNoOfArgs {
            get {
                return ResourceManager.GetString("InvNoOfArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid port number given..
        /// </summary>
        internal static string InvPort {
            get {
                return ResourceManager.GetString("InvPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} connection(s) terminated..
        /// </summary>
        internal static string IPDisconnected {
            get {
                return ResourceManager.GetString("IPDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nlconsole..
        /// </summary>
        internal static string NLConsolePrompt {
            get {
                return ResourceManager.GetString("NLConsolePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Neural Link.
        /// </summary>
        internal static string NLConsoleTitle {
            get {
                return ResourceManager.GetString("NLConsoleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No server exists on given port. .
        /// </summary>
        internal static string NoServerOnPort {
            get {
                return ResourceManager.GetString("NoServerOnPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port.
        /// </summary>
        internal static string Port {
            get {
                return ResourceManager.GetString("Port", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server.
        /// </summary>
        internal static string Server {
            get {
                return ResourceManager.GetString("Server", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server was abnormally terminated on port {0}: {1}..
        /// </summary>
        internal static string ServerAbnormallyTerminated {
            get {
                return ResourceManager.GetString("ServerAbnormallyTerminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has been added to port {1}..
        /// </summary>
        internal static string ServerAdded {
            get {
                return ResourceManager.GetString("ServerAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server is already connected..
        /// </summary>
        internal static string ServerAlreadyConnected {
            get {
                return ResourceManager.GetString("ServerAlreadyConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A server already exists on port {0}..
        /// </summary>
        internal static string ServerExistsOnPort {
            get {
                return ResourceManager.GetString("ServerExistsOnPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server is not connected..
        /// </summary>
        internal static string ServerNotConnected {
            get {
                return ResourceManager.GetString("ServerNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time taken to hash: {0} seconds.
        /// </summary>
        internal static string TimeTakenToHash {
            get {
                return ResourceManager.GetString("TimeTakenToHash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognised action..
        /// </summary>
        internal static string UnrecognisedAction {
            get {
                return ResourceManager.GetString("UnrecognisedAction", resourceCulture);
            }
        }
    }
}
