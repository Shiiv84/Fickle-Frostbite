﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GarminTo.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GarminTo.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SELECT	sys.server_role_members.role_principal_id, 
        ///		role.name AS RoleName, 
        ///		sys.server_role_members.member_principal_id, 
        ///		member.name AS MemberName
        ///FROM	sys.server_role_members
        ///JOIN sys.server_principals AS role ON sys.server_role_members.role_principal_id = role.principal_id
        ///JOIN sys.server_principals AS member ON sys.server_role_members.member_principal_id = member.principal_id
        ///WHERE	member.name = &apos;{username}&apos;
        ///		AND role.name = &apos;sysadmin&apos;.
        /// </summary>
        internal static string GarminToSQL_ConfirmPermissions {
            get {
                return ResourceManager.GetString("GarminToSQL_ConfirmPermissions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF (NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = &apos;{DatabaseName}&apos;))
        ///BEGIN
        ///	CREATE DATABASE [{DatabaseName}]
        ///END
        ///.
        /// </summary>
        internal static string GarminToSQL_CreateDatabase {
            get {
                return ResourceManager.GetString("GarminToSQL_CreateDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to use [{DatabaseName}]
        ///GO
        ///
        ///IF NOT EXISTS (SELECT * FROM sysobjects WHERE xtype=&apos;U&apos; AND name = &apos;DatabaseVersion&apos;)
        ///BEGIN
        ///	CREATE TABLE [dbo].[DatabaseVersion]([VersionNumber] [nvarchar](25) NOT NULL,
        ///								         [LastUpdated] [datetime] NOT NULL,
        ///										 [SchemaUpdatedBy] [nvarchar](250) NOT NULL) ON [PRIMARY]
        ///	ALTER TABLE [dbo].[DatabaseVersion] ADD CONSTRAINT [DF_DatabaseVersion_LastUpdated]  DEFAULT (getdate()) FOR [LastUpdated]
        ///END
        ///GO
        ///
        ///IF NOT EXISTS (SELECT * FROM sysobjects WHERE xtype= [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GarminToSQL_CreateTables {
            get {
                return ResourceManager.GetString("GarminToSQL_CreateTables", resourceCulture);
            }
        }
    }
}
