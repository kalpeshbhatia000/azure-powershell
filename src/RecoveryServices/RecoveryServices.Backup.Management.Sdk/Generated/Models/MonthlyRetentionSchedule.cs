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
    /// Monthly retention schedule.
    /// </summary>
    public partial class MonthlyRetentionSchedule
    {
        /// <summary>
        /// Initializes a new instance of the MonthlyRetentionSchedule class.
        /// </summary>
        public MonthlyRetentionSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonthlyRetentionSchedule class.
        /// </summary>
        /// <param name="retentionScheduleFormatType">Retention schedule format
        /// type for monthly retention policy. Possible values include:
        /// 'Invalid', 'Daily', 'Weekly'</param>
        /// <param name="retentionScheduleDaily">Daily retention format for
        /// monthly retention policy.</param>
        /// <param name="retentionScheduleWeekly">Weekly retention format for
        /// monthly retention policy.</param>
        /// <param name="retentionTimes">Retention times of retention
        /// policy.</param>
        /// <param name="retentionDuration">Retention duration of retention
        /// Policy.</param>
        public MonthlyRetentionSchedule(string retentionScheduleFormatType = default(string), DailyRetentionFormat retentionScheduleDaily = default(DailyRetentionFormat), WeeklyRetentionFormat retentionScheduleWeekly = default(WeeklyRetentionFormat), IList<System.DateTime?> retentionTimes = default(IList<System.DateTime?>), RetentionDuration retentionDuration = default(RetentionDuration))
        {
            RetentionScheduleFormatType = retentionScheduleFormatType;
            RetentionScheduleDaily = retentionScheduleDaily;
            RetentionScheduleWeekly = retentionScheduleWeekly;
            RetentionTimes = retentionTimes;
            RetentionDuration = retentionDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets retention schedule format type for monthly retention
        /// policy. Possible values include: 'Invalid', 'Daily', 'Weekly'
        /// </summary>
        [JsonProperty(PropertyName = "retentionScheduleFormatType")]
        public string RetentionScheduleFormatType { get; set; }

        /// <summary>
        /// Gets or sets daily retention format for monthly retention policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionScheduleDaily")]
        public DailyRetentionFormat RetentionScheduleDaily { get; set; }

        /// <summary>
        /// Gets or sets weekly retention format for monthly retention policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionScheduleWeekly")]
        public WeeklyRetentionFormat RetentionScheduleWeekly { get; set; }

        /// <summary>
        /// Gets or sets retention times of retention policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionTimes")]
        public IList<System.DateTime?> RetentionTimes { get; set; }

        /// <summary>
        /// Gets or sets retention duration of retention Policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionDuration")]
        public RetentionDuration RetentionDuration { get; set; }

    }
}
