---
Module Name: Az.Accounts
Module Guid: 342714fc-4009-4863-8afb-a9067e3db04b
Download Help Link: https://learn.microsoft.com/powershell/module/az.accounts
Help Version: 4.6.0.0
Locale: en-US
moduleStatus: preview
moduleStatusMessage: Placeholder text. This module has been deprecated. Please view https://aka.ms/azps-refstatus.
---

# Az.Accounts Module
## Description
Manages credentials and common configuration for all Azure modules.

## Az.Accounts Cmdlets
### [Add-AzEnvironment](Add-AzEnvironment.md)
Adds endpoints and metadata for an instance of Azure Resource Manager.

### [Clear-AzConfig](Clear-AzConfig.md)
Clears the values of configs that are set by the user.

### [Clear-AzContext](Clear-AzContext.md)
Remove all Azure credentials, account, and subscription information.

### [Clear-AzDefault](Clear-AzDefault.md)
Clears the defaults set by the user in the current context.

### [Connect-AzAccount](Connect-AzAccount.md)
Connect to Azure with an authenticated account for use with cmdlets from the Az PowerShell modules.

### [Disable-AzContextAutosave](Disable-AzContextAutosave.md)
Turn off autosaving Azure credentials.  Your login information will be forgotten the next time you open a PowerShell window

### [Disable-AzDataCollection](Disable-AzDataCollection.md)
Opts out of collecting data to improve the Azure PowerShell cmdlets. Data is collected by default
unless you explicitly opt out.

### [Disable-AzureRmAlias](Disable-AzureRmAlias.md)
Disables AzureRm prefix aliases for Az modules.

### [Disconnect-AzAccount](Disconnect-AzAccount.md)
Disconnects a connected Azure account and removes all credentials and contexts associated with that account.

### [Enable-AzContextAutosave](Enable-AzContextAutosave.md)
Azure contexts are PowerShell objects representing your active subscription to run commands against,
and the authentication information needed to connect to an Azure cloud. With Azure contexts, Azure
PowerShell doesn't need to reauthenticate your account each time you switch subscriptions. For more
information, see [Azure PowerShell context objects](https://learn.microsoft.com/powershell/azure/context-persistence).

This cmdlet allows the Azure context information to be saved and automatically loaded when you start
a PowerShell process. For example, when opening a new window.

### [Enable-AzDataCollection](Enable-AzDataCollection.md)
Enables Azure PowerShell to collect data to improve the user experience with the Azure PowerShell
cmdlets. Executing this cmdlet opts in to data collection for the current user on the current
machine. Data is collected by default unless you explicitly opt out.

### [Enable-AzureRmAlias](Enable-AzureRmAlias.md)
Enables AzureRm prefix aliases for Az modules.

### [Export-AzConfig](Export-AzConfig.md)
Exports all the configs into a file so that it can be imported on another machine.

### [Get-AzAccessToken](Get-AzAccessToken.md)
Get secure access token. When using -ResourceUrl, please make sure the value does match current Azure environment. You may refer to the value of `(Get-AzContext).Environment`.

> [!NOTE]
> For security purposes, the default output type has been changed from a plain text `String` to `SecureString`. For more information, see [Protect secrets in Azure PowerShell](https://go.microsoft.com/fwlink/?linkid=2258844).

### [Get-AzConfig](Get-AzConfig.md)
Gets the configs of Azure PowerShell.

### [Get-AzContext](Get-AzContext.md)
Gets the metadata used to authenticate Azure Resource Manager requests.

### [Get-AzContextAutosaveSetting](Get-AzContextAutosaveSetting.md)
Display metadata about the context autosave feature, including whether the context is 
automatically saved, and where saved context and credential information can be found.

### [Get-AzDefault](Get-AzDefault.md)
Get the defaults set by the user in the current context.

### [Get-AzEnvironment](Get-AzEnvironment.md)
Get endpoints and metadata for an instance of Azure services.
`GalleryUrl` will be removed from ArmMetadata and so Azure PowerShell will no longer provide for its value in `PSAzureEnvironment`. Currently `GalleryUrl` is not used in Azure PowerShell products. Please do not reply on `GalleryUrl` anymore. 

### [Get-AzSubscription](Get-AzSubscription.md)
Get subscriptions that the current account can access.

### [Get-AzTenant](Get-AzTenant.md)
Gets tenants that are authorized for the current user.

### [Import-AzConfig](Import-AzConfig.md)
Imports configs from a file that was previously exported by `Export-AzConfig`.

### [Import-AzContext](Import-AzContext.md)
Loads Azure authentication information from a file.

### [Invoke-AzRestMethod](Invoke-AzRestMethod.md)
Construct and perform HTTP request to Azure resource management endpoint only

### [Open-AzSurveyLink](Open-AzSurveyLink.md)
Open survey link in default browser.

### [Register-AzModule](Register-AzModule.md)
FOR INTERNAL USE ONLY - Provide Runtime Support for AutoRest Generated cmdlets

### [Remove-AzContext](Remove-AzContext.md)
Remove a context from the set of available contexts

### [Remove-AzEnvironment](Remove-AzEnvironment.md)
Removes endpoints and metadata for connecting to a given Azure instance.

### [Rename-AzContext](Rename-AzContext.md)
Rename an Azure context.  By default contexts are named by user account and subscription.

### [Resolve-AzError](Resolve-AzError.md)
Display detailed information about PowerShell errors, with extended details for Azure PowerShell errors.

### [Save-AzContext](Save-AzContext.md)
Saves the current authentication information for use in other PowerShell sessions.

### [Select-AzContext](Select-AzContext.md)
Select a subscription and account to target in Azure PowerShell cmdlets

### [Send-Feedback](Send-Feedback.md)
Sends feedback to the Azure PowerShell team via a set of guided prompts.

### [Set-AzContext](Set-AzContext.md)
Sets the tenant, subscription, and environment for cmdlets to use in the current session.

### [Set-AzDefault](Set-AzDefault.md)
Sets a default in the current context

### [Set-AzEnvironment](Set-AzEnvironment.md)
Sets properties for an Azure environment.

### [Uninstall-AzureRm](Uninstall-AzureRm.md)
Removes all AzureRm modules from a machine.

### [Update-AzConfig](Update-AzConfig.md)
Updates the configs of Azure PowerShell.

