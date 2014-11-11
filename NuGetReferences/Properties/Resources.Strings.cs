#region Apache Licensed
/*
 Copyright 2013 Daniel Cazzulino

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Globalization;

namespace Kzu.NuGetReferences.Properties
{
	///	<summary>
	///	Provides access to string resources.
	///	</summary>
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	static partial class Strings
	{
		/// <summary>
		/// Looks up a localized string similar to: 
		///	(Executing Command)
		/// </summary>
		public static string ExecutingCommand { get { return Resources.ExecutingCommand; } }
	
		/// <summary>
		/// Looks up a localized string similar to: 
		///	Failed to load NuGet Package Manager. Please contact support.
		/// </summary>
		public static string FailedToLoadNuGetPackage { get { return Resources.FailedToLoadNuGetPackage; } }
	
		/// <summary>
		/// Looks up a localized string similar to: 
		///	Your currently installed version of NuGet Package Manager is version {installedVersion}, but the {productName} extension was tested with version {buildVersion}. Some functionality may not work as expected.
		/// </summary>
		public static string IncompatibleNuGet(object installedVersion, object productName, object buildVersion)
		{
			return Resources.IncompatibleNuGet.FormatWith(new 
			{
				installedVersion = installedVersion,
				productName = productName,
				buildVersion = buildVersion,
			});
		}
	
		/// <summary>
		/// Looks up a localized string similar to: 
		///	(Initializing NuGet Console)
		/// </summary>
		public static string InitializingConsole { get { return Resources.InitializingConsole; } }
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class PackageInfo
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	General
			/// </summary>
			public static string Category { get { return Resources.PackageInfo_Category; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	NuGet Package
			/// </summary>
			public static string DisplayName { get { return Resources.PackageInfo_DisplayName; } }
			
			///	<summary>
			///	Provides access to string resources.
			///	</summary>
			[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public static partial class Id
			{
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Package identifier.
				/// </summary>
				public static string Description { get { return Resources.PackageInfo_Id_Description; } }
			
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Id
				/// </summary>
				public static string DisplayName { get { return Resources.PackageInfo_Id_DisplayName; } }
			}
			
			///	<summary>
			///	Provides access to string resources.
			///	</summary>
			[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public static partial class Version
			{
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Package version.
				/// </summary>
				public static string Description { get { return Resources.PackageInfo_Version_Description; } }
			
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Version
				/// </summary>
				public static string DisplayName { get { return Resources.PackageInfo_Version_DisplayName; } }
			}
			
			///	<summary>
			///	Provides access to string resources.
			///	</summary>
			[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public static partial class Title
			{
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Package title.
				/// </summary>
				public static string Description { get { return Resources.PackageInfo_Title_Description; } }
			
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Title
				/// </summary>
				public static string DisplayName { get { return Resources.PackageInfo_Title_DisplayName; } }
			}
			
			///	<summary>
			///	Provides access to string resources.
			///	</summary>
			[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public static partial class Authors
			{
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Package authors.
				/// </summary>
				public static string Description { get { return Resources.PackageInfo_Authors_Description; } }
			
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Authors
				/// </summary>
				public static string DisplayName { get { return Resources.PackageInfo_Authors_DisplayName; } }
			}
			
			///	<summary>
			///	Provides access to string resources.
			///	</summary>
			[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public static partial class InstallPath
			{
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Package installation location.
				/// </summary>
				public static string Description { get { return Resources.PackageInfo_InstallPath_Description; } }
			
				/// <summary>
				/// Looks up a localized string similar to: 
				///	Install Path
				/// </summary>
				public static string DisplayName { get { return Resources.PackageInfo_InstallPath_DisplayName; } }
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Uninstall
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Uninstall
			/// </summary>
			public static string Text { get { return Resources.Uninstall_Text; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Update
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Update
			/// </summary>
			public static string Text { get { return Resources.Update_Text; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Package
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Installing DevStore version {version} from {vsixPath}.
			/// </summary>
			public static string DevStoreInstalling(object version, object vsixPath)
			{
				return Resources.Package_DevStoreInstalling.FormatWith(new 
				{
					version = version,
					vsixPath = vsixPath,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	DevStore is currently not installed.
			/// </summary>
			public static string DevStoreNotInstalled { get { return Resources.Package_DevStoreNotInstalled; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Installed DevStore version is {oldVersion}. Upgrading to {newVersion}.
			/// </summary>
			public static string DevStoreOldVersion(object oldVersion, object newVersion)
			{
				return Resources.Package_DevStoreOldVersion.FormatWith(new 
				{
					oldVersion = oldVersion,
					newVersion = newVersion,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Latest version of DevStore will be activated on your next Visual Studio restart.
			/// </summary>
			public static string DevStoreRestartNeeded { get { return Resources.Package_DevStoreRestartNeeded; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Could not find DevStore installer at {vsixPath}. Please reinstall {product}.
			/// </summary>
			public static string DevStoreVsixNotFound(object vsixPath, object product)
			{
				return Resources.Package_DevStoreVsixNotFound.FormatWith(new 
				{
					vsixPath = vsixPath,
					product = product,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Verifying current version of DevStore
			/// </summary>
			public static string VerifyingDevStore { get { return Resources.Package_VerifyingDevStore; } }
		}
	}
}

