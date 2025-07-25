// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// BareMetalMachineConfigurationData represents configuration for the bare metal machine.
    /// </summary>
    public partial class BareMetalMachineConfigurationData :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationData,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationDataInternal
    {

        /// <summary>Backing field for <see cref="BmcConnectionString" /> property.</summary>
        private string _bmcConnectionString;

        /// <summary>
        /// The connection string for the baseboard management controller including IP address and protocol.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string BmcConnectionString { get => this._bmcConnectionString; }

        /// <summary>Backing field for <see cref="BmcCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentials _bmcCredentials;

        /// <summary>
        /// The credentials of the baseboard management controller on this bare metal machine. The password field is expected to be
        /// an Azure Key Vault key URL. Until the cluster is converted to utilize managed identity by setting the secret archive settings,
        /// the actual password value should be provided instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentials BmcCredentials { get => (this._bmcCredentials = this._bmcCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministrativeCredentials()); set => this._bmcCredentials = value; }

        /// <summary>The password of the administrator of the device used during initialization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public System.Security.SecureString BmcCredentialsPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentialsInternal)BmcCredentials).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentialsInternal)BmcCredentials).Password = value ; }

        /// <summary>The username of the administrator of the device used during initialization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string BmcCredentialsUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentialsInternal)BmcCredentials).Username; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentialsInternal)BmcCredentials).Username = value ; }

        /// <summary>Backing field for <see cref="BmcMacAddress" /> property.</summary>
        private string _bmcMacAddress;

        /// <summary>The MAC address of the BMC for this machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string BmcMacAddress { get => this._bmcMacAddress; set => this._bmcMacAddress = value; }

        /// <summary>Backing field for <see cref="BootMacAddress" /> property.</summary>
        private string _bootMacAddress;

        /// <summary>The MAC address associated with the PXE NIC card.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string BootMacAddress { get => this._bootMacAddress; set => this._bootMacAddress = value; }

        /// <summary>Backing field for <see cref="MachineDetail" /> property.</summary>
        private string _machineDetail;

        /// <summary>The free-form additional information about the machine, e.g. an asset tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string MachineDetail { get => this._machineDetail; set => this._machineDetail = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>
        /// The user-provided name for the bare metal machine created from this specification.
        /// If not provided, the machine name will be generated programmatically.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Internal Acessors for BmcConnectionString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationDataInternal.BmcConnectionString { get => this._bmcConnectionString; set { {_bmcConnectionString = value;} } }

        /// <summary>Internal Acessors for BmcCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentials Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationDataInternal.BmcCredentials { get => (this._bmcCredentials = this._bmcCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministrativeCredentials()); set { {_bmcCredentials = value;} } }

        /// <summary>Backing field for <see cref="RackSlot" /> property.</summary>
        private long _rackSlot;

        /// <summary>The slot the physical machine is in the rack based on the BOM configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long RackSlot { get => this._rackSlot; set => this._rackSlot = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>
        /// The serial number of the machine. Hardware suppliers may use an alternate value. For example, service tag.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Creates an new <see cref="BareMetalMachineConfigurationData" /> instance.</summary>
        public BareMetalMachineConfigurationData()
        {

        }
    }
    /// BareMetalMachineConfigurationData represents configuration for the bare metal machine.
    public partial interface IBareMetalMachineConfigurationData :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The connection string for the baseboard management controller including IP address and protocol.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The connection string for the baseboard management controller including IP address and protocol.",
        SerializedName = @"bmcConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string BmcConnectionString { get;  }
        /// <summary>The password of the administrator of the device used during initialization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The password of the administrator of the device used during initialization.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString BmcCredentialsPassword { get; set; }
        /// <summary>The username of the administrator of the device used during initialization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The username of the administrator of the device used during initialization.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string BmcCredentialsUsername { get; set; }
        /// <summary>The MAC address of the BMC for this machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The MAC address of the BMC for this machine.",
        SerializedName = @"bmcMacAddress",
        PossibleTypes = new [] { typeof(string) })]
        string BmcMacAddress { get; set; }
        /// <summary>The MAC address associated with the PXE NIC card.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The MAC address associated with the PXE NIC card.",
        SerializedName = @"bootMacAddress",
        PossibleTypes = new [] { typeof(string) })]
        string BootMacAddress { get; set; }
        /// <summary>The free-form additional information about the machine, e.g. an asset tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The free-form additional information about the machine, e.g. an asset tag.",
        SerializedName = @"machineDetails",
        PossibleTypes = new [] { typeof(string) })]
        string MachineDetail { get; set; }
        /// <summary>
        /// The user-provided name for the bare metal machine created from this specification.
        /// If not provided, the machine name will be generated programmatically.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user-provided name for the bare metal machine created from this specification.
        If not provided, the machine name will be generated programmatically.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>The slot the physical machine is in the rack based on the BOM configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The slot the physical machine is in the rack based on the BOM configuration.",
        SerializedName = @"rackSlot",
        PossibleTypes = new [] { typeof(long) })]
        long RackSlot { get; set; }
        /// <summary>
        /// The serial number of the machine. Hardware suppliers may use an alternate value. For example, service tag.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The serial number of the machine. Hardware suppliers may use an alternate value. For example, service tag.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }

    }
    /// BareMetalMachineConfigurationData represents configuration for the bare metal machine.
    internal partial interface IBareMetalMachineConfigurationDataInternal

    {
        /// <summary>
        /// The connection string for the baseboard management controller including IP address and protocol.
        /// </summary>
        string BmcConnectionString { get; set; }
        /// <summary>
        /// The credentials of the baseboard management controller on this bare metal machine. The password field is expected to be
        /// an Azure Key Vault key URL. Until the cluster is converted to utilize managed identity by setting the secret archive settings,
        /// the actual password value should be provided instead.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAdministrativeCredentials BmcCredentials { get; set; }
        /// <summary>The password of the administrator of the device used during initialization.</summary>
        System.Security.SecureString BmcCredentialsPassword { get; set; }
        /// <summary>The username of the administrator of the device used during initialization.</summary>
        string BmcCredentialsUsername { get; set; }
        /// <summary>The MAC address of the BMC for this machine.</summary>
        string BmcMacAddress { get; set; }
        /// <summary>The MAC address associated with the PXE NIC card.</summary>
        string BootMacAddress { get; set; }
        /// <summary>The free-form additional information about the machine, e.g. an asset tag.</summary>
        string MachineDetail { get; set; }
        /// <summary>
        /// The user-provided name for the bare metal machine created from this specification.
        /// If not provided, the machine name will be generated programmatically.
        /// </summary>
        string MachineName { get; set; }
        /// <summary>The slot the physical machine is in the rack based on the BOM configuration.</summary>
        long RackSlot { get; set; }
        /// <summary>
        /// The serial number of the machine. Hardware suppliers may use an alternate value. For example, service tag.
        /// </summary>
        string SerialNumber { get; set; }

    }
}