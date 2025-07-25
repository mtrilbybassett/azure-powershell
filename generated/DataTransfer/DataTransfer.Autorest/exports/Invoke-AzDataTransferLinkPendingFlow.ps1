
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
Links the specified flow.
.Description
Links the specified flow.
.Example
$sendFlow = Get-AzDataTransferFlow -ResourceGroupName ResourceGroup01 -ConnectionName SendConnection01 -FlowName SendFlow01
Invoke-AzDataTransferLinkPendingFlow -ResourceGroupName ResourceGroup02 -ConnectionName ReceiveConnection01 -FlowName ReceiveFlow01 -PendingFlowId $sendFlow.Id -StatusReason "Linking approved" -Confirm:$false

.Inputs
ADT.Models.IDataTransferIdentity
.Inputs
ADT.Models.IResourceBody
.Outputs
ADT.Models.IFlow
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

CONNECTIONINPUTOBJECT <IDataTransferIdentity>: Identity Parameter
  [ConnectionName <String>]: The name for the connection to perform the operation on.
  [FlowName <String>]: The name for the flow to perform the operation on.
  [Id <String>]: Resource identity path
  [PipelineName <String>]: The name for the pipeline to perform the operation on.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.

FLOW <IResourceBody>: The resource to reference.
  Id <String>: ID of the resource.
  [StatusReason <String>]: Reason for resource operation.

INPUTOBJECT <IDataTransferIdentity>: Identity Parameter
  [ConnectionName <String>]: The name for the connection to perform the operation on.
  [FlowName <String>]: The name for the flow to perform the operation on.
  [Id <String>]: Resource identity path
  [PipelineName <String>]: The name for the pipeline to perform the operation on.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
.Link
https://learn.microsoft.com/powershell/module/az.datatransfer/invoke-azdatatransferlinkpendingflow
#>
function Invoke-AzDataTransferLinkPendingFlow {
[OutputType([ADT.Models.IFlow])]
[CmdletBinding(DefaultParameterSetName='LinkExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonString', Mandatory)]
    [ADT.Category('Path')]
    [System.String]
    # The name for the connection to perform the operation on.
    ${ConnectionName},

    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityConnection', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityConnectionExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonString', Mandatory)]
    [ADT.Category('Path')]
    [System.String]
    # The name for the flow to perform the operation on.
    ${FlowName},

    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='LinkViaJsonString', Mandatory)]
    [ADT.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Link')]
    [Parameter(ParameterSetName='LinkExpanded')]
    [Parameter(ParameterSetName='LinkViaJsonFilePath')]
    [Parameter(ParameterSetName='LinkViaJsonString')]
    [ADT.Category('Path')]
    [ADT.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [ADT.Category('Path')]
    [ADT.Models.IDataTransferIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='LinkViaIdentityConnection', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentityConnectionExpanded', Mandatory, ValueFromPipeline)]
    [ADT.Category('Path')]
    [ADT.Models.IDataTransferIdentity]
    # Identity Parameter
    ${ConnectionInputObject},

    [Parameter(ParameterSetName='Link', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentityConnection', Mandatory, ValueFromPipeline)]
    [ADT.Category('Body')]
    [ADT.Models.IResourceBody]
    # The resource to reference.
    ${Flow},

    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityConnectionExpanded', Mandatory)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory)]
    [ADT.Category('Body')]
    [System.String]
    # ID of the resource.
    ${PendingFlowId},

    [Parameter(ParameterSetName='LinkExpanded')]
    [Parameter(ParameterSetName='LinkViaIdentityConnectionExpanded')]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded')]
    [ADT.Category('Body')]
    [System.String]
    # Reason for resource operation.
    ${StatusReason},

    [Parameter(ParameterSetName='LinkViaJsonFilePath', Mandatory)]
    [ADT.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Link operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='LinkViaJsonString', Mandatory)]
    [ADT.Category('Body')]
    [System.String]
    # Json string supplied to the Link operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [ADT.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [ADT.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [ADT.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [ADT.Category('Runtime')]
    [ADT.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [ADT.Category('Runtime')]
    [ADT.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [ADT.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [ADT.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [ADT.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [ADT.Category('Runtime')]
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
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('ADT.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

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
            [ADT.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            Link = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_Link';
            LinkExpanded = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkExpanded';
            LinkViaIdentity = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaIdentity';
            LinkViaIdentityConnection = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaIdentityConnection';
            LinkViaIdentityConnectionExpanded = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaIdentityConnectionExpanded';
            LinkViaIdentityExpanded = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaIdentityExpanded';
            LinkViaJsonFilePath = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaJsonFilePath';
            LinkViaJsonString = 'Az.DataTransfer.private\Invoke-AzDataTransferLinkPendingFlow_LinkViaJsonString';
        }
        if (('Link', 'LinkExpanded', 'LinkViaJsonFilePath', 'LinkViaJsonString') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [ADT.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [ADT.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [ADT.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [ADT.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
