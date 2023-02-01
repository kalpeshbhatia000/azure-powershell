// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Disk information
    /// </summary>
    public partial class DiskInformation
    {
        /// <summary>
        /// Initializes a new instance of the DiskInformation class.
        /// </summary>
        public DiskInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskInformation class.
        /// </summary>
        public DiskInformation(int? lun = default(int?), string name = default(string))
        {
            Lun = lun;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
