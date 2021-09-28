// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2ACrossClusterMigration cloud creation input.</summary>
    public partial class A2ACrossClusterMigrationContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationContainerCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationContainerCreationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInput __replicationProviderSpecificContainerCreationInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificContainerCreationInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInputInternal)__replicationProviderSpecificContainerCreationInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInputInternal)__replicationProviderSpecificContainerCreationInput).InstanceType = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="A2ACrossClusterMigrationContainerCreationInput" /> instance.
        /// </summary>
        public A2ACrossClusterMigrationContainerCreationInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__replicationProviderSpecificContainerCreationInput), __replicationProviderSpecificContainerCreationInput);
            await eventListener.AssertObjectIsValid(nameof(__replicationProviderSpecificContainerCreationInput), __replicationProviderSpecificContainerCreationInput);
        }
    }
    /// A2ACrossClusterMigration cloud creation input.
    public partial interface IA2ACrossClusterMigrationContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInput
    {

    }
    /// A2ACrossClusterMigration cloud creation input.
    internal partial interface IA2ACrossClusterMigrationContainerCreationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificContainerCreationInputInternal
    {

    }
}