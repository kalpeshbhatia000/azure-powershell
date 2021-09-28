namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class SystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemData,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; }

        /// <summary>Backing field for <see cref="CreatedByType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? _createdByType;

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? CreatedByType { get => this._createdByType; }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        /// <summary>The timestamp of the last modification the resource (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; }

        /// <summary>Backing field for <see cref="LastModifiedBy" /> property.</summary>
        private string _lastModifiedBy;

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string LastModifiedBy { get => this._lastModifiedBy; }

        /// <summary>Backing field for <see cref="LastModifiedByType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? _lastModifiedByType;

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? LastModifiedByType { get => this._lastModifiedByType; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedBy { get => this._createdBy; set { {_createdBy = value;} } }

        /// <summary>Internal Acessors for CreatedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.CreatedByType { get => this._createdByType; set { {_createdByType = value;} } }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedAt { get => this._lastModifiedAt; set { {_lastModifiedAt = value;} } }

        /// <summary>Internal Acessors for LastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedBy { get => this._lastModifiedBy; set { {_lastModifiedBy = value;} } }

        /// <summary>Internal Acessors for LastModifiedByType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ISystemDataInternal.LastModifiedByType { get => this._lastModifiedByType; set { {_lastModifiedByType = value;} } }

        /// <summary>Creates an new <see cref="SystemData" /> instance.</summary>
        public SystemData()
        {

        }
    }
    /// Metadata pertaining to creation and last modification of the resource.
    public partial interface ISystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? CreatedByType { get;  }
        /// <summary>The timestamp of the last modification the resource (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp of the last modification the resource (UTC).",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? LastModifiedByType { get;  }

    }
    /// Metadata pertaining to creation and last modification of the resource.
    internal partial interface ISystemDataInternal

    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string CreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.CreatedByType? CreatedByType { get; set; }
        /// <summary>The timestamp of the last modification the resource (UTC).</summary>
        global::System.DateTime? LastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string LastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.LastModifiedByType? LastModifiedByType { get; set; }

    }
}