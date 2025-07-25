// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// ClusterMetricsConfigurationProperties represents the properties of metrics configuration for the cluster.
    /// </summary>
    public partial class ClusterMetricsConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CollectionInterval" /> property.</summary>
        private long _collectionInterval;

        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long CollectionInterval { get => this._collectionInterval; set => this._collectionInterval = value; }

        /// <summary>Backing field for <see cref="DetailedStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus? _detailedStatus;

        /// <summary>The more detailed status of the metrics configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus? DetailedStatus { get => this._detailedStatus; }

        /// <summary>Backing field for <see cref="DetailedStatusMessage" /> property.</summary>
        private string _detailedStatusMessage;

        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string DetailedStatusMessage { get => this._detailedStatusMessage; }

        /// <summary>Backing field for <see cref="DisabledMetric" /> property.</summary>
        private string[] _disabledMetric;

        /// <summary>
        /// The list of metrics that are available for the cluster but disabled at the moment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] DisabledMetric { get => this._disabledMetric; }

        /// <summary>Backing field for <see cref="EnabledMetric" /> property.</summary>
        private string[] _enabledMetric;

        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] EnabledMetric { get => this._enabledMetric; set => this._enabledMetric = value; }

        /// <summary>Internal Acessors for DetailedStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal.DetailedStatus { get => this._detailedStatus; set { {_detailedStatus = value;} } }

        /// <summary>Internal Acessors for DetailedStatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal.DetailedStatusMessage { get => this._detailedStatusMessage; set { {_detailedStatusMessage = value;} } }

        /// <summary>Internal Acessors for DisabledMetric</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal.DisabledMetric { get => this._disabledMetric; set { {_disabledMetric = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the metrics configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="ClusterMetricsConfigurationProperties" /> instance.</summary>
        public ClusterMetricsConfigurationProperties()
        {

        }
    }
    /// ClusterMetricsConfigurationProperties represents the properties of metrics configuration for the cluster.
    public partial interface IClusterMetricsConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The interval in minutes by which metrics will be collected.",
        SerializedName = @"collectionInterval",
        PossibleTypes = new [] { typeof(long) })]
        long CollectionInterval { get; set; }
        /// <summary>The more detailed status of the metrics configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The more detailed status of the metrics configuration.",
        SerializedName = @"detailedStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus? DetailedStatus { get;  }
        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The descriptive message about the current detailed status.",
        SerializedName = @"detailedStatusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string DetailedStatusMessage { get;  }
        /// <summary>
        /// The list of metrics that are available for the cluster but disabled at the moment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of metrics that are available for the cluster but disabled at the moment.",
        SerializedName = @"disabledMetrics",
        PossibleTypes = new [] { typeof(string) })]
        string[] DisabledMetric { get;  }
        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.",
        SerializedName = @"enabledMetrics",
        PossibleTypes = new [] { typeof(string) })]
        string[] EnabledMetric { get; set; }
        /// <summary>The provisioning state of the metrics configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the metrics configuration.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState? ProvisioningState { get;  }

    }
    /// ClusterMetricsConfigurationProperties represents the properties of metrics configuration for the cluster.
    internal partial interface IClusterMetricsConfigurationPropertiesInternal

    {
        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        long CollectionInterval { get; set; }
        /// <summary>The more detailed status of the metrics configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus? DetailedStatus { get; set; }
        /// <summary>The descriptive message about the current detailed status.</summary>
        string DetailedStatusMessage { get; set; }
        /// <summary>
        /// The list of metrics that are available for the cluster but disabled at the moment.
        /// </summary>
        string[] DisabledMetric { get; set; }
        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        string[] EnabledMetric { get; set; }
        /// <summary>The provisioning state of the metrics configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState? ProvisioningState { get; set; }

    }
}