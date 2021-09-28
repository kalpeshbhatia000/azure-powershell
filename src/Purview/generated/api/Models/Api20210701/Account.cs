namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Account resource</summary>
    public partial class Account :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.TrackedResource();

        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId; }

        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt; }

        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy; }

        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CreatedByObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId; }

        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog; }

        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian; }

        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan; }

        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName; }

        /// <summary>Gets or sets the identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Id; }

        /// <summary>Identity Info on the tracked resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IIdentity Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Identity = value ?? null /* model class */; }

        /// <summary>Service principal object Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityPrincipalId; }

        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityTenantId; }

        /// <summary>Identity Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type)""); }

        /// <summary>Gets or sets the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace; }

        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup; }

        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroupName = value ?? null; }

        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount; }

        /// <summary>Internal Acessors for CloudConnector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.CloudConnector { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnector; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnector = value; }

        /// <summary>Internal Acessors for CloudConnectorAwsExternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt = value; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy = value; }

        /// <summary>Internal Acessors for CreatedByObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.CreatedByObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId = value; }

        /// <summary>Internal Acessors for Endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.Endpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).Endpoint = value; }

        /// <summary>Internal Acessors for EndpointCatalog</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog = value; }

        /// <summary>Internal Acessors for EndpointGuardian</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian = value; }

        /// <summary>Internal Acessors for EndpointScan</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName = value; }

        /// <summary>Internal Acessors for ManagedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.ManagedResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResource = value; }

        /// <summary>Internal Acessors for ManagedResourceEventHubNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace = value; }

        /// <summary>Internal Acessors for ManagedResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup = value; }

        /// <summary>Internal Acessors for ManagedResourceStorageAccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount = value; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSku Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).IdentityTenantId = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Type = value; }

        /// <summary>Gets or sets the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Name; }

        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties _property;

        /// <summary>Gets or sets the properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountProperties()); set => this._property = value; }

        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess)""); }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSku _sku;

        /// <summary>Gets or sets the Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountSku()); set => this._sku = value; }

        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public int? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSkuInternal)Sku).Capacity = value ?? default(int); }

        /// <summary>Gets or sets the sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSkuInternal)Sku).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name)""); }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of the last modification the resource (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Tags on the azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Gets or sets the type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Account" /> instance.</summary>
        public Account()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Account resource
    public partial interface IAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResource
    {
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"AWS external identifier.
        Configured in AWS to allow use of the role arn used for scanning",
        SerializedName = @"awsExternalId",
        PossibleTypes = new [] { typeof(string) })]
        string CloudConnectorAwsExternalId { get;  }
        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the time at which the entity was created.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creator of the entity.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get;  }
        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creators of the entity's object id.",
        SerializedName = @"createdByObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByObjectId { get;  }
        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the catalog endpoint.",
        SerializedName = @"catalog",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointCatalog { get;  }
        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the guardian endpoint.",
        SerializedName = @"guardian",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointGuardian { get;  }
        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the scan endpoint.",
        SerializedName = @"scan",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointScan { get;  }
        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the friendly name.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get;  }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed event hub namespace resource identifier.",
        SerializedName = @"eventHubNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceEventHubNamespace { get;  }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroup { get;  }
        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the managed resource group name",
        SerializedName = @"managedResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed storage account resource identifier.",
        SerializedName = @"storageAccount",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceStorageAccount { get;  }
        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the private endpoint connections information.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get;  }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the state of the provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the public network access.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku capacity. Possible values include: 4, 16",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacity { get; set; }
        /// <summary>Gets or sets the sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? SkuName { get; set; }

    }
    /// Account resource
    internal partial interface IAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceInternal
    {
        /// <summary>
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors CloudConnector { get; set; }
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        string CloudConnectorAwsExternalId { get; set; }
        /// <summary>Gets the time at which the entity was created.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>Gets the creator of the entity.</summary>
        string CreatedBy { get; set; }
        /// <summary>Gets the creators of the entity's object id.</summary>
        string CreatedByObjectId { get; set; }
        /// <summary>The URIs that are the public endpoints of the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Endpoint { get; set; }
        /// <summary>Gets the catalog endpoint.</summary>
        string EndpointCatalog { get; set; }
        /// <summary>Gets the guardian endpoint.</summary>
        string EndpointGuardian { get; set; }
        /// <summary>Gets the scan endpoint.</summary>
        string EndpointScan { get; set; }
        /// <summary>Gets or sets the friendly name.</summary>
        string FriendlyName { get; set; }
        /// <summary>Gets the resource identifiers of the managed resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources ManagedResource { get; set; }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        string ManagedResourceEventHubNamespace { get; set; }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        string ManagedResourceGroup { get; set; }
        /// <summary>Gets or sets the managed resource group name</summary>
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        string ManagedResourceStorageAccount { get; set; }
        /// <summary>Gets the private endpoint connections information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>Gets or sets the properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Property { get; set; }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Gets or sets the public network access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Gets or sets the Sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSku Sku { get; set; }
        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        int? SkuCapacity { get; set; }
        /// <summary>Gets or sets the sku name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? SkuName { get; set; }

    }
}