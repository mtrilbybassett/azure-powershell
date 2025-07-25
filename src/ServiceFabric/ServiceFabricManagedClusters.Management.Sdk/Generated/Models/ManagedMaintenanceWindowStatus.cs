// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the maintenance window status of the Service Fabric Managed
    /// Cluster.
    /// </summary>
    public partial class ManagedMaintenanceWindowStatus
    {
        /// <summary>
        /// Initializes a new instance of the ManagedMaintenanceWindowStatus class.
        /// </summary>
        public ManagedMaintenanceWindowStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedMaintenanceWindowStatus class.
        /// </summary>

        /// <param name="isWindowEnabled">If maintenance window is enabled on this cluster.
        /// </param>

        /// <param name="isRegionReady">Indicates if the region is ready to configure maintenance windows.
        /// </param>

        /// <param name="isWindowActive">If maintenance window is active.
        /// </param>

        /// <param name="canApplyUpdates">If updates can be applied.
        /// </param>

        /// <param name="lastWindowStatusUpdateAtUtc">Last window update time in UTC.
        /// </param>

        /// <param name="lastWindowStartTimeUtc">Last window start time in UTC.
        /// </param>

        /// <param name="lastWindowEndTimeUtc">Last window end time in UTC.
        /// </param>
        public ManagedMaintenanceWindowStatus(bool? isWindowEnabled = default(bool?), bool? isRegionReady = default(bool?), bool? isWindowActive = default(bool?), bool? canApplyUpdates = default(bool?), System.DateTime? lastWindowStatusUpdateAtUtc = default(System.DateTime?), System.DateTime? lastWindowStartTimeUtc = default(System.DateTime?), System.DateTime? lastWindowEndTimeUtc = default(System.DateTime?))

        {
            this.IsWindowEnabled = isWindowEnabled;
            this.IsRegionReady = isRegionReady;
            this.IsWindowActive = isWindowActive;
            this.CanApplyUpdates = canApplyUpdates;
            this.LastWindowStatusUpdateAtUtc = lastWindowStatusUpdateAtUtc;
            this.LastWindowStartTimeUtc = lastWindowStartTimeUtc;
            this.LastWindowEndTimeUtc = lastWindowEndTimeUtc;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets if maintenance window is enabled on this cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isWindowEnabled")]
        public bool? IsWindowEnabled {get; private set; }

        /// <summary>
        /// Gets indicates if the region is ready to configure maintenance windows.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isRegionReady")]
        public bool? IsRegionReady {get; private set; }

        /// <summary>
        /// Gets if maintenance window is active.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isWindowActive")]
        public bool? IsWindowActive {get; private set; }

        /// <summary>
        /// Gets if updates can be applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canApplyUpdates")]
        public bool? CanApplyUpdates {get; private set; }

        /// <summary>
        /// Gets last window update time in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastWindowStatusUpdateAtUTC")]
        public System.DateTime? LastWindowStatusUpdateAtUtc {get; private set; }

        /// <summary>
        /// Gets last window start time in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastWindowStartTimeUTC")]
        public System.DateTime? LastWindowStartTimeUtc {get; private set; }

        /// <summary>
        /// Gets last window end time in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastWindowEndTimeUTC")]
        public System.DateTime? LastWindowEndTimeUtc {get; private set; }
    }
}