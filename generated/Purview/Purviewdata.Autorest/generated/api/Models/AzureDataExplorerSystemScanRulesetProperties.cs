// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.DoNotFormat]
    public partial class AzureDataExplorerSystemScanRulesetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerSystemScanRulesetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerSystemScanRulesetPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerScanRulesetProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerScanRulesetProperties __azureDataExplorerScanRulesetProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureDataExplorerScanRulesetProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).Description = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ExcludedSystemClassification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).ExcludedSystemClassification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).ExcludedSystemClassification = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> IncludedCustomClassificationRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).IncludedCustomClassificationRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).IncludedCustomClassificationRuleName = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).LastModifiedAt; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanRulesetPropertiesInternal)__azureDataExplorerScanRulesetProperties).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>
        /// Creates an new <see cref="AzureDataExplorerSystemScanRulesetProperties" /> instance.
        /// </summary>
        public AzureDataExplorerSystemScanRulesetProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureDataExplorerScanRulesetProperties), __azureDataExplorerScanRulesetProperties);
            await eventListener.AssertObjectIsValid(nameof(__azureDataExplorerScanRulesetProperties), __azureDataExplorerScanRulesetProperties);
        }
    }
    public partial interface IAzureDataExplorerSystemScanRulesetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerScanRulesetProperties
    {

    }
    internal partial interface IAzureDataExplorerSystemScanRulesetPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureDataExplorerScanRulesetPropertiesInternal
    {

    }
}