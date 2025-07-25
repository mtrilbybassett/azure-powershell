
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
Update a new action group or update an existing one.
.Description
Update a new action group or update an existing one.
.Example
$enventhub = New-AzActionGroupEventHubReceiverObject -EventHubName "testEventHub" -EventHubNameSpace "actiongrouptest" -Name "sample eventhub" -SubscriptionId '{subid}'
Update-AzActionGroup -Name actiongroup1 -ResourceGroupName monitor-action -EventHubReceiver $enventhub
.Example
$ag = Get-AzActionGroup -Name actiongroup1 -ResourceGroupName monitor-action
Update-AzActionGroup -InputObject $ag -EventHubReceiver $null

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ARMROLERECEIVER <IArmRoleReceiver[]>: The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported.
  Name <String>: The name of the arm role receiver. Names must be unique across all receivers within an action group.
  RoleId <String>: The arm role id.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

AUTOMATIONRUNBOOKRECEIVER <IAutomationRunbookReceiver[]>: The list of AutomationRunbook receivers that are part of this action group.
  AutomationAccountId <String>: The Azure automation account Id which holds this runbook and authenticate to Azure resource.
  IsGlobalRunbook <Boolean>: Indicates whether this instance is global runbook.
  RunbookName <String>: The name for this runbook.
  WebhookResourceId <String>: The resource id for webhook linked to this runbook.
  [Name <String>]: Indicates name of the webhook.
  [ServiceUri <String>]: The URI where webhooks should be sent.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

AZUREAPPPUSHRECEIVER <IAzureAppPushReceiver[]>: The list of AzureAppPush receivers that are part of this action group.
  EmailAddress <String>: The email address registered for the Azure mobile app.
  Name <String>: The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group.

AZUREFUNCTIONRECEIVER <IAzureFunctionReceiver[]>: The list of azure function receivers that are part of this action group.
  FunctionAppResourceId <String>: The azure resource id of the function app.
  FunctionName <String>: The function name in the function app.
  HttpTriggerUrl <String>: The http trigger url where http request sent to.
  Name <String>: The name of the azure function receiver. Names must be unique across all receivers within an action group.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

EMAILRECEIVER <IEmailReceiver[]>: The list of email receivers that are part of this action group.
  EmailAddress <String>: The email address of this receiver.
  Name <String>: The name of the email receiver. Names must be unique across all receivers within an action group.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

EVENTHUBRECEIVER <IEventHubReceiver[]>: The list of event hub receivers that are part of this action group.
  EventHubName <String>: The name of the specific Event Hub queue
  EventHubNameSpace <String>: The Event Hub namespace
  Name <String>: The name of the Event hub receiver. Names must be unique across all receivers within an action group.
  SubscriptionId <String>: The Id for the subscription containing this event hub
  [TenantId <String>]: The tenant Id for the subscription containing this event hub
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

INPUTOBJECT <IActionGroupIdentity>: Identity Parameter
  [ActionGroupName <String>]: The name of the action group.
  [Id <String>]: Resource identity path
  [NotificationId <String>]: The notification id
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.

ITSMRECEIVER <IItsmReceiver[]>: The list of ITSM receivers that are part of this action group.
  ConnectionId <String>: Unique identification of ITSM connection among multiple defined in above workspace.
  Name <String>: The name of the Itsm receiver. Names must be unique across all receivers within an action group.
  Region <String>: Region in which workspace resides. Supported values:'centralindia','japaneast','southeastasia','australiasoutheast','uksouth','westcentralus','canadacentral','eastus','westeurope'
  TicketConfiguration <String>: JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.
  WorkspaceId <String>: OMS LA instance identifier.

LOGICAPPRECEIVER <ILogicAppReceiver[]>: The list of logic app receivers that are part of this action group.
  CallbackUrl <String>: The callback url where http request sent to.
  Name <String>: The name of the logic app receiver. Names must be unique across all receivers within an action group.
  ResourceId <String>: The azure resource id of the logic app receiver.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.

SMSRECEIVER <ISmsReceiver[]>: The list of SMS receivers that are part of this action group.
  CountryCode <String>: The country code of the SMS receiver.
  Name <String>: The name of the SMS receiver. Names must be unique across all receivers within an action group.
  PhoneNumber <String>: The phone number of the SMS receiver.

VOICERECEIVER <IVoiceReceiver[]>: The list of voice receivers that are part of this action group.
  CountryCode <String>: The country code of the voice receiver.
  Name <String>: The name of the voice receiver. Names must be unique across all receivers within an action group.
  PhoneNumber <String>: The phone number of the voice receiver.

WEBHOOKRECEIVER <IWebhookReceiver[]>: The list of webhook receivers that are part of this action group.
  Name <String>: The name of the webhook receiver. Names must be unique across all receivers within an action group.
  ServiceUri <String>: The URI where webhooks should be sent.
  [IdentifierUri <String>]: Indicates the identifier uri for aad auth.
  [ObjectId <String>]: Indicates the webhook app object Id for aad auth.
  [TenantId <String>]: Indicates the tenant id for aad auth.
  [UseAadAuth <Boolean?>]: Indicates whether or not use AAD authentication.
  [UseCommonAlertSchema <Boolean?>]: Indicates whether to use common alert schema.
.Link
https://learn.microsoft.com/powershell/module/az.monitor/update-azactiongroup
#>
function Update-AzActionGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupResource])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ActionGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Path')]
    [System.String]
    # The name of the action group.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IActionGroupIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IArmRoleReceiver[]]
    # The list of ARM role receivers that are part of this action group.
    # Roles are Azure RBAC roles and only built-in roles are supported.
    ${ArmRoleReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IAutomationRunbookReceiver[]]
    # The list of AutomationRunbook receivers that are part of this action group.
    ${AutomationRunbookReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IAzureAppPushReceiver[]]
    # The list of AzureAppPush receivers that are part of this action group.
    ${AzureAppPushReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IAzureFunctionReceiver[]]
    # The list of azure function receivers that are part of this action group.
    ${AzureFunctionReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IEmailReceiver[]]
    # The list of email receivers that are part of this action group.
    ${EmailReceiver},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether this action group is enabled.
    # If an action group is not enabled, then none of its receivers will receive communications.
    ${Enabled},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IEventHubReceiver[]]
    # The list of event hub receivers that are part of this action group.
    ${EventHubReceiver},

    [Parameter()]
    [Alias('ShortName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [System.String]
    # The short name of the action group.
    # This will be used in SMS messages.
    ${GroupShortName},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IItsmReceiver[]]
    # The list of ITSM receivers that are part of this action group.
    ${ItsmReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.ILogicAppReceiver[]]
    # The list of logic app receivers that are part of this action group.
    ${LogicAppReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.ISmsReceiver[]]
    # The list of SMS receivers that are part of this action group.
    ${SmsReceiver},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IAzureResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IVoiceReceiver[]]
    # The list of voice receivers that are part of this action group.
    ${VoiceReceiver},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Models.IWebhookReceiver[]]
    # The list of webhook receivers that are part of this action group.
    ${WebhookReceiver},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Category('Runtime')]
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
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

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
            [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            UpdateExpanded = 'Az.ActionGroup.private\Update-AzActionGroup_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.ActionGroup.private\Update-AzActionGroup_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActionGroup.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
