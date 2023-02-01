// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupStatusOperations.
    /// </summary>
    public static partial class BackupStatusOperationsExtensions
    {
            /// <summary>
            /// Get the container backup status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// Container Backup Status Request
            /// </param>
            public static BackupStatusResponse Get(this IBackupStatusOperations operations, string azureRegion, BackupStatusRequest parameters)
            {
                return operations.GetAsync(azureRegion, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the container backup status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='parameters'>
            /// Container Backup Status Request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupStatusResponse> GetAsync(this IBackupStatusOperations operations, string azureRegion, BackupStatusRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(azureRegion, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
