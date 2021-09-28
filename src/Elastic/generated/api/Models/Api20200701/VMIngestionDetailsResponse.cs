// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>The vm ingestion details to install an agent.</summary>
    public partial class VMIngestionDetailsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IVMIngestionDetailsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IVMIngestionDetailsResponseInternal
    {

        /// <summary>Backing field for <see cref="CloudId" /> property.</summary>
        private string _cloudId;

        /// <summary>The cloudId of given Elastic monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string CloudId { get => this._cloudId; set => this._cloudId = value; }

        /// <summary>Backing field for <see cref="IngestionKey" /> property.</summary>
        private string _ingestionKey;

        /// <summary>Ingestion details to install agent on given VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string IngestionKey { get => this._ingestionKey; set => this._ingestionKey = value; }

        /// <summary>Creates an new <see cref="VMIngestionDetailsResponse" /> instance.</summary>
        public VMIngestionDetailsResponse()
        {

        }
    }
    /// The vm ingestion details to install an agent.
    public partial interface IVMIngestionDetailsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>The cloudId of given Elastic monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cloudId of given Elastic monitor resource.",
        SerializedName = @"cloudId",
        PossibleTypes = new [] { typeof(string) })]
        string CloudId { get; set; }
        /// <summary>Ingestion details to install agent on given VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ingestion details to install agent on given VM.",
        SerializedName = @"ingestionKey",
        PossibleTypes = new [] { typeof(string) })]
        string IngestionKey { get; set; }

    }
    /// The vm ingestion details to install an agent.
    internal partial interface IVMIngestionDetailsResponseInternal

    {
        /// <summary>The cloudId of given Elastic monitor resource.</summary>
        string CloudId { get; set; }
        /// <summary>Ingestion details to install agent on given VM.</summary>
        string IngestionKey { get; set; }

    }
}