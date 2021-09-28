// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>A datastore resource</summary>
    public partial class Datastore :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastore,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.Resource();

        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumeLunName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeLunName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeLunName = value ?? null; }

        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeMountOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeMountOption = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum)""); }

        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumePath; }

        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumeTargetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeTargetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumeTargetId = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for DiskPoolVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal.DiskPoolVolume { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolume; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolume = value; }

        /// <summary>Internal Acessors for DiskPoolVolumePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal.DiskPoolVolumePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).DiskPoolVolumePath = value; }

        /// <summary>Internal Acessors for NetAppVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal.NetAppVolume { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).NetAppVolume; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).NetAppVolume = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.DatastoreProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Name; }

        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string NetAppVolumeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).NetAppVolumeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).NetAppVolumeId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreProperties _property;

        /// <summary>The properties of a datastore resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.DatastoreProperties()); set => this._property = value; }

        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Datastore" /> instance.</summary>
        public Datastore()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A datastore resource
    public partial interface IDatastore :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResource
    {
        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the LUN to be used for datastore",
        SerializedName = @"lunName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN",
        SerializedName = @"mountOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get; set; }
        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Device path",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumePath { get;  }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource ID of the iSCSI target",
        SerializedName = @"targetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumeTargetId { get; set; }
        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource ID of the NetApp volume",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetAppVolumeId { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the datastore provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get;  }

    }
    /// A datastore resource
    internal partial interface IDatastoreInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceInternal
    {
        /// <summary>An iSCSI volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume DiskPoolVolume { get; set; }
        /// <summary>Name of the LUN to be used for datastore</summary>
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get; set; }
        /// <summary>Device path</summary>
        string DiskPoolVolumePath { get; set; }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        string DiskPoolVolumeTargetId { get; set; }
        /// <summary>An Azure NetApp Files volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume NetAppVolume { get; set; }
        /// <summary>Azure resource ID of the NetApp volume</summary>
        string NetAppVolumeId { get; set; }
        /// <summary>The properties of a datastore resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreProperties Property { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get; set; }

    }
}