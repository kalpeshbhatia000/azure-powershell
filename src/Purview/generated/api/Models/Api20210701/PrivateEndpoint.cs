namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>A private endpoint class.</summary>
    public partial class PrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The private endpoint identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="PrivateEndpoint" /> instance.</summary>
        public PrivateEndpoint()
        {

        }
    }
    /// A private endpoint class.
    public partial interface IPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The private endpoint identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private endpoint identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// A private endpoint class.
    internal partial interface IPrivateEndpointInternal

    {
        /// <summary>The private endpoint identifier.</summary>
        string Id { get; set; }

    }
}