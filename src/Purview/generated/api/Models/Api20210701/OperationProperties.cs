namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>properties on meta info</summary>
    public partial class OperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification _serviceSpecification;

        /// <summary>meta service specification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationMetaServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecificationInternal)ServiceSpecification).MetricSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecificationInternal)ServiceSpecification).MetricSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationProperties" /> instance.</summary>
        public OperationProperties()
        {

        }
    }
    /// properties on meta info
    public partial interface IOperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"log specifications for the operation",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"metric specifications for the operation",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
    /// properties on meta info
    internal partial interface IOperationPropertiesInternal

    {
        /// <summary>meta service specification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification ServiceSpecification { get; set; }
        /// <summary>log specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
}