// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Filter details to transfer Azure Blobs</summary>
    public partial class BlobFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetailsInternal
    {

        /// <summary>Backing field for <see cref="BlobPathList" /> property.</summary>
        private string[] _blobPathList;

        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string[] BlobPathList { get => this._blobPathList; set => this._blobPathList = value; }

        /// <summary>Backing field for <see cref="BlobPrefixList" /> property.</summary>
        private string[] _blobPrefixList;

        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string[] BlobPrefixList { get => this._blobPrefixList; set => this._blobPrefixList = value; }

        /// <summary>Backing field for <see cref="ContainerList" /> property.</summary>
        private string[] _containerList;

        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string[] ContainerList { get => this._containerList; set => this._containerList = value; }

        /// <summary>Creates an new <see cref="BlobFilterDetails" /> instance.</summary>
        public BlobFilterDetails()
        {

        }
    }
    /// Filter details to transfer Azure Blobs
    public partial interface IBlobFilterDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>List of full path of the blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of full path of the blobs to be transferred.",
        SerializedName = @"blobPathList",
        PossibleTypes = new [] { typeof(string) })]
        string[] BlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Prefix list of the Azure blobs to be transferred.",
        SerializedName = @"blobPrefixList",
        PossibleTypes = new [] { typeof(string) })]
        string[] BlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of blob containers to be transferred.",
        SerializedName = @"containerList",
        PossibleTypes = new [] { typeof(string) })]
        string[] ContainerList { get; set; }

    }
    /// Filter details to transfer Azure Blobs
    internal partial interface IBlobFilterDetailsInternal

    {
        /// <summary>List of full path of the blobs to be transferred.</summary>
        string[] BlobPathList { get; set; }
        /// <summary>Prefix list of the Azure blobs to be transferred.</summary>
        string[] BlobPrefixList { get; set; }
        /// <summary>List of blob containers to be transferred.</summary>
        string[] ContainerList { get; set; }

    }
}