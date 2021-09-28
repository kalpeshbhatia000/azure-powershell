// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>A list of the available script packages</summary>
    public partial class ScriptPackagesList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackagesList,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackagesListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackagesListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackagesListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage[] _value;

        /// <summary>List of script package resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="ScriptPackagesList" /> instance.</summary>
        public ScriptPackagesList()
        {

        }
    }
    /// A list of the available script packages
    public partial interface IScriptPackagesList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next page if any",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of script package resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of script package resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage[] Value { get;  }

    }
    /// A list of the available script packages
    internal partial interface IScriptPackagesListInternal

    {
        /// <summary>URL to get the next page if any</summary>
        string NextLink { get; set; }
        /// <summary>List of script package resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptPackage[] Value { get; set; }

    }
}