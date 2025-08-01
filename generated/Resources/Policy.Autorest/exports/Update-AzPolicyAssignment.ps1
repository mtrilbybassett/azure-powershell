
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
This operation updates a policy assignment with the given scope and name.
Policy assignments apply to all resources contained within their scope.
For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
.Description
This operation updates a policy assignment with the given scope and name.
Policy assignments apply to all resources contained within their scope.
For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
.Example
$ResourceGroup = Get-AzResourceGroup -Name 'ResourceGroup11'
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment' -Scope $ResourceGroup.ResourceId
Update-AzPolicyAssignment -Id $PolicyAssignment.Id -DisplayName 'Do not allow VM creation'
.Example
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment'
Update-AzPolicyAssignment -Id $PolicyAssignment.Id -IdentityType 'SystemAssigned' -Location 'westus'
.Example
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment'
$UserAssignedIdentity = Get-AzUserAssignedIdentity -ResourceGroupName 'ResourceGroup1' -Name 'UserAssignedIdentity1'
 Update-AzPolicyAssignment -Id $PolicyAssignment.Id -IdentityType 'UserAssigned' -Location 'westus' -IdentityId $UserAssignedIdentity.Id
.Example
$Locations = Get-AzLocation | Where-Object {($_.displayname -like 'france*') -or ($_.displayname -like 'uk*')}
$AllowedLocations = @{'listOfAllowedLocations'=($Locations.location)}
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment'
Update-AzPolicyAssignment -Id $PolicyAssignment.Id -PolicyParameterObject $AllowedLocations
.Example
{
  "listOfAllowedLocations":  {
    "value": [
      "uksouth",
      "ukwest",
      "francecentral",
      "francesouth"
    ]
  }
}

Update-AzPolicyAssignment -Name 'PolicyAssignment' -PolicyParameter .\AllowedLocations.json
.Example
$ResourceGroup = Get-AzResourceGroup -Name 'ResourceGroup11'
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment' -Scope $ResourceGroup.ResourceId
Update-AzPolicyAssignment -Id $PolicyAssignment.Id -EnforcementMode Default
.Example
$PolicyAssignment = Get-AzPolicyAssignment -Name 'VirtualMachinePolicy'
Update-AzPolicyAssignment -Id $PolicyAssignment.Id -NonComplianceMessage @{Message="All resources must follow resource naming guidelines."}
.Example
$ResourceSelector = @{Name = "MyLocationSelector"; Selector = @(@{Kind = "resourceLocation"; NotIn = @("eastus", "eastus2")})}
Update-AzPolicyAssignment -Name 'VirtualMachinePolicyAssignment' -ResourceSelector $ResourceSelector
.Example
$Selector = @{Kind = "resourceLocation"; NotIn = @("eastus", "eastus2")}
$Override = @(@{Kind = "policyEffect"; Value = 'Disabled'; Selector = @($Selector)})
Update-AzPolicyAssignment -Name 'VirtualMachinePolicyAssignment' -Override $Override
.Example
$ResourceGroup = Get-AzResourceGroup -Name 'ResourceGroup11'
$PolicyAssignment = Get-AzPolicyAssignment -Name 'PolicyAssignment' -Scope $ResourceGroup.ResourceId -BackwardCompatible
Set-AzPolicyAssignment -Id $PolicyAssignment.ResourceId -EnforcementMode Default

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyAssignment
.Inputs
System.Management.Automation.PSObject[]
.Inputs
System.String
.Inputs
System.String[]
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyAssignment
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IPolicyAssignment>: 
  [DefinitionVersion <String>]: The version of the policy definition to use.
  [Description <String>]: This message will be part of response in case of policy violation.
  [DisplayName <String>]: The display name of the policy assignment.
  [EnforcementMode <String>]: The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
  [IdentityType <String>]: The identity type. This is the only required field when adding a system or user assigned identity to a resource.
  [IdentityUserAssignedIdentity <IIdentityUserAssignedIdentities>]: The user identity associated with the policy. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    [(Any) <IUserAssignedIdentitiesValue>]: This indicates any property can be added to this object.
  [Location <String>]: The location of the policy assignment. Only required when utilizing managed identity.
  [Metadata <IPolicyAssignmentPropertiesMetadata>]: The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [NonComplianceMessage <List<INonComplianceMessage>>]: The messages that describe why a resource is non-compliant with the policy.
    Message <String>: A message that describes why a resource is non-compliant with the policy. This is shown in 'deny' error messages and on resource's non-compliant compliance results.
    [PolicyDefinitionReferenceId <String>]: The policy definition reference ID within a policy set definition the message is intended for. This is only applicable if the policy assignment assigns a policy set definition. If this is not provided the message applies to all policies assigned by this policy assignment.
  [NotScope <List<String>>]: The policy's excluded scopes.
  [Override <List<IOverride>>]: The policy property value override.
    [Kind <String>]: The override kind.
    [Selector <List<ISelector>>]: The list of the selector expressions.
      [In <List<String>>]: The list of values to filter in.
      [Kind <String>]: The selector kind.
      [NotIn <List<String>>]: The list of values to filter out.
    [Value <String>]: The value to override the policy property.
  [Parameter <IParameterValues>]: The parameter values for the assigned policy rule. The keys are the parameter names.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [PolicyDefinitionId <String>]: The ID of the policy definition or policy set definition being assigned.
  [ResourceSelector <List<IResourceSelector>>]: The resource selector list to filter policies by resource properties.
    [Name <String>]: The name of the resource selector.
    [Selector <List<ISelector>>]: The list of the selector expressions.

OVERRIDE <IOverride[]>: The policy property value override.
  [Kind <String>]: The override kind.
  [Selector <List<ISelector>>]: The list of the selector expressions.
    [In <List<String>>]: The list of values to filter in.
    [Kind <String>]: The selector kind.
    [NotIn <List<String>>]: The list of values to filter out.
  [Value <String>]: The value to override the policy property.

RESOURCESELECTOR <IResourceSelector[]>: The resource selector list to filter policies by resource properties.
  [Name <String>]: The name of the resource selector.
  [Selector <List<ISelector>>]: The list of the selector expressions.
    [In <List<String>>]: The list of values to filter in.
    [Kind <String>]: The selector kind.
    [NotIn <List<String>>]: The list of values to filter out.
.Link
https://learn.microsoft.com/powershell/module/az.resources/update-azpolicyassignment
#>
function Update-AzPolicyAssignment {
[Alias('Set-AzPolicyAssignment')]
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyAssignment])]
[CmdletBinding(DefaultParameterSetName='Name', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Name', Mandatory, ValueFromPipelineByPropertyName)]
    [Parameter(ParameterSetName='NameParameterString', Mandatory, ValueFromPipelineByPropertyName)]
    [Parameter(ParameterSetName='NameParameterObject', Mandatory, ValueFromPipelineByPropertyName)]
    [Alias('PolicyAssignmentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The name of the policy assignment.
    ${Name},

    [Parameter(ParameterSetName='Name', ValueFromPipelineByPropertyName)]
    [Parameter(ParameterSetName='NameParameterString', ValueFromPipelineByPropertyName)]
    [Parameter(ParameterSetName='NameParameterObject', ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The scope of the policy assignment.
    # Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
    ${Scope},

    [Parameter(ParameterSetName='IdParameterString', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='IdParameterObject', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='Id', Mandatory, ValueFromPipeline)]
    [Alias('ResourceId', 'PolicyAssignmentId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The ID of the policy assignment to update.
    # Use the format '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
    ${Id},

    [Parameter(ValueFromPipelineByPropertyName)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String[]]
    # The policy's excluded scopes.
    ${NotScope},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The display name of the policy assignment.
    ${DisplayName},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # This message will be part of response in case of policy violation.
    ${Description},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyAssignmentPropertiesMetadata]))]
    [System.String]
    # The policy assignment metadata.
    # Metadata is an open ended object and is typically a collection of key value pairs.
    ${Metadata},

    [Parameter(ValueFromPipelineByPropertyName)]
    [ArgumentCompleter({ LocationCompleter })]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The location of the policy assignment.
    # Only required when utilizing managed identity.
    ${Location},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("Default", "DoNotEnforce")]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The policy assignment enforcement mode.
    # Possible values are Default and DoNotEnforce.
    ${EnforcementMode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned")]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The identity type.
    # This is the only required field when adding a system or user assigned identity to a resource.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The user identity associated with the policy.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    ${IdentityId},

    [Parameter(ValueFromPipelineByPropertyName)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.INonComplianceMessage[]]))]
    [System.Management.Automation.PSObject[]]
    # The messages that describe why a resource is non-compliant with the policy.
    # To construct, see NOTES section for NONCOMPLIANCEMESSAGE properties and create a hash table.
    ${NonComplianceMessage},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IOverride[]]
    # The policy property value override.
    ${Override},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector[]]
    # The resource selector list to filter policies by resource properties.
    ${ResourceSelector},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Causes cmdlet to return artifacts using legacy format placing policy-specific properties in a property bag object.
    ${BackwardCompatible},

    [Parameter(ParameterSetName='NameParameterString', Mandatory, ValueFromPipelineByPropertyName)]
    [Parameter(ParameterSetName='IdParameterString', Mandatory, ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The parameter values for the assigned policy rule.
    # The keys are the parameter names.
    ${PolicyParameter},

    [Parameter(ParameterSetName='NameParameterObject', Mandatory)]
    [Parameter(ParameterSetName='IdParameterObject', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.Management.Automation.PSObject]
    # The parameter values for the assigned policy rule.
    # The keys are the parameter names.
    ${PolicyParameterObject},

    [Parameter(ParameterSetName='InputObject', Mandatory, ValueFromPipeline, ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyAssignment]
    # 
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $context = Get-AzContext
        if (-not $context -and -not $testPlayback) {
            Write-Error "No Azure login detected. Please run 'Connect-AzAccount' to log in."
            exit
        }

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Policy.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            Name = 'Az.Policy.custom\Update-AzPolicyAssignment';
            NameParameterString = 'Az.Policy.custom\Update-AzPolicyAssignment';
            NameParameterObject = 'Az.Policy.custom\Update-AzPolicyAssignment';
            IdParameterString = 'Az.Policy.custom\Update-AzPolicyAssignment';
            IdParameterObject = 'Az.Policy.custom\Update-AzPolicyAssignment';
            Id = 'Az.Policy.custom\Update-AzPolicyAssignment';
            InputObject = 'Az.Policy.custom\Update-AzPolicyAssignment';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Policy.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
