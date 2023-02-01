// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SAPHana specific recoverypoint, specifically encapsulates full/diff
    /// recoverypoints
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureWorkloadSAPHanaRecoveryPoint")]
    public partial class AzureWorkloadSAPHanaRecoveryPoint : AzureWorkloadRecoveryPoint
    {
        /// <summary>
        /// Initializes a new instance of the AzureWorkloadSAPHanaRecoveryPoint
        /// class.
        /// </summary>
        public AzureWorkloadSAPHanaRecoveryPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureWorkloadSAPHanaRecoveryPoint
        /// class.
        /// </summary>
        /// <param name="recoveryPointTimeInUTC">UTC time at which recovery
        /// point was created</param>
        /// <param name="type">Type of restore point. Possible values include:
        /// 'Invalid', 'Full', 'Log', 'Differential', 'Incremental',
        /// 'SnapshotFull', 'SnapshotCopyOnlyFull'</param>
        /// <param name="recoveryPointTierDetails">Recovery point tier
        /// information.</param>
        /// <param name="recoveryPointMoveReadinessInfo">Eligibility of RP to
        /// be moved to another tier</param>
        /// <param name="recoveryPointProperties">Properties of Recovery
        /// Point</param>
        public AzureWorkloadSAPHanaRecoveryPoint(System.DateTime? recoveryPointTimeInUTC = default(System.DateTime?), string type = default(string), IList<RecoveryPointTierInformationV2> recoveryPointTierDetails = default(IList<RecoveryPointTierInformationV2>), IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo = default(IDictionary<string, RecoveryPointMoveReadinessInfo>), RecoveryPointProperties recoveryPointProperties = default(RecoveryPointProperties))
            : base(recoveryPointTimeInUTC, type, recoveryPointTierDetails, recoveryPointMoveReadinessInfo, recoveryPointProperties)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
