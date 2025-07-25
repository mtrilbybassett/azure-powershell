// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// BareMetalMachineCordonParameters represents the body of the request to evacuate workloads from node on a bare metal machine.
    /// </summary>
    public partial class BareMetalMachineCordonParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineCordonParameters,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineCordonParametersInternal
    {

        /// <summary>Backing field for <see cref="Evacuate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BareMetalMachineEvacuate? _evacuate;

        /// <summary>
        /// The indicator of whether to evacuate the node workload when the bare metal machine is cordoned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BareMetalMachineEvacuate? Evacuate { get => this._evacuate; set => this._evacuate = value; }

        /// <summary>Creates an new <see cref="BareMetalMachineCordonParameters" /> instance.</summary>
        public BareMetalMachineCordonParameters()
        {

        }
    }
    /// BareMetalMachineCordonParameters represents the body of the request to evacuate workloads from node on a bare metal machine.
    public partial interface IBareMetalMachineCordonParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The indicator of whether to evacuate the node workload when the bare metal machine is cordoned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The indicator of whether to evacuate the node workload when the bare metal machine is cordoned.",
        SerializedName = @"evacuate",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BareMetalMachineEvacuate) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BareMetalMachineEvacuate? Evacuate { get; set; }

    }
    /// BareMetalMachineCordonParameters represents the body of the request to evacuate workloads from node on a bare metal machine.
    internal partial interface IBareMetalMachineCordonParametersInternal

    {
        /// <summary>
        /// The indicator of whether to evacuate the node workload when the bare metal machine is cordoned.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BareMetalMachineEvacuate? Evacuate { get; set; }

    }
}