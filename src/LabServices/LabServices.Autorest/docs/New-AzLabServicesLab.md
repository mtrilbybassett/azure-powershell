---
external help file:
Module Name: Az.LabServices
online version: https://learn.microsoft.com/powershell/module/az.labservices/new-azlabserviceslab
schema: 2.0.0
---

# New-AzLabServicesLab

## SYNOPSIS
Operation to create a lab resource.

## SYNTAX

### CreateExpanded (Default)
```
New-AzLabServicesLab -Name <String> -ResourceGroupName <String> -Location <String> [-SubscriptionId <String>]
 [-AdditionalCapabilityInstallGpuDriver <String>] [-AdminUserPassword <SecureString>]
 [-AdminUserUsername <String>] [-AutoShutdownProfileDisconnectDelay <TimeSpan>]
 [-AutoShutdownProfileIdleDelay <TimeSpan>] [-AutoShutdownProfileNoConnectDelay <TimeSpan>]
 [-AutoShutdownProfileShutdownOnDisconnect <String>] [-AutoShutdownProfileShutdownOnIdle <String>]
 [-AutoShutdownProfileShutdownWhenNotConnected <String>] [-ConnectionProfileClientRdpAccess <String>]
 [-ConnectionProfileClientSshAccess <String>] [-ConnectionProfileWebRdpAccess <String>]
 [-ConnectionProfileWebSshAccess <String>] [-Description <String>] [-ImageReferenceId <String>]
 [-ImageReferenceOffer <String>] [-ImageReferencePublisher <String>] [-ImageReferenceSku <String>]
 [-ImageReferenceVersion <String>] [-LabPlanId <String>] [-NetworkProfileLoadBalancerId <String>]
 [-NetworkProfilePublicIPId <String>] [-NetworkProfileSubnetId <String>]
 [-NonAdminUserPassword <SecureString>] [-NonAdminUserUsername <String>]
 [-RosterProfileActiveDirectoryGroupId <String>] [-RosterProfileLmsInstance <String>]
 [-RosterProfileLtiClientId <String>] [-RosterProfileLtiContextId <String>]
 [-RosterProfileLtiRosterEndpoint <String>] [-SecurityProfileOpenAccess <String>] [-SkuCapacity <Int32>]
 [-SkuFamily <String>] [-SkuName <String>] [-SkuSize <String>] [-SkuTier <String>] [-Tag <Hashtable>]
 [-Title <String>] [-VirtualMachineProfileCreateOption <String>] [-VirtualMachineProfileUsageQuota <TimeSpan>]
 [-VirtualMachineProfileUseSharedPassword <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzLabServicesLab -Name <String> -ResourceGroupName <String> -JsonFilePath <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzLabServicesLab -Name <String> -ResourceGroupName <String> -JsonString <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Operation to create a lab resource.

## EXAMPLES

### Example 1: Create a new lab.
```powershell
New-AzLabServicesLab `
        -Name "NewLab" `
        -ResourceGroupName $ENV:ResourceGroupName `
        -Location $ENV:Location `
        -AdditionalCapabilityInstallGpuDriver Disabled `
        -AdminUserPassword "PlaceholderPassword" `
        -AdminUserUsername "PlaceholderAccountName" `
        -AutoShutdownProfileShutdownOnDisconnect Disabled `
        -AutoShutdownProfileShutdownOnIdle None `
        -AutoShutdownProfileShutdownWhenNotConnected Disabled `
        -ConnectionProfileClientRdpAccess Public `
        -ConnectionProfileClientSshAccess None `
        -ConnectionProfileWebRdpAccess None `
        -ConnectionProfileWebSshAccess None `
        -Description "New lab description" `
        -ImageReferenceOffer "Windows-10" `
        -ImageReferencePublisher "MicrosoftWindowsDesktop" `
        -ImageReferenceSku "20h2-pro" `
        -ImageReferenceVersion "latest" `
        -SecurityProfileOpenAccess Disabled `
        -SkuCapacity 3 `
        -SkuName "Standard" `
        -Title $ENV:NewLabName `
        -VirtualMachineProfileCreateOption "TemplateVM" `
        -VirtualMachineProfileUseSharedPassword Enabled
```

```output
Location Name
-------- ----
westus2  NewLab
```

Creates a new Lab.

## PARAMETERS

### -AdditionalCapabilityInstallGpuDriver
Flag to pre-install dedicated GPU drivers.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminUserPassword
The password for the user.
This is required for the TemplateVM createOption.

```yaml
Type: System.Security.SecureString
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminUserUsername
The username to use when signing in to lab VMs.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileDisconnectDelay
The amount of time a VM will stay running after a user disconnects if this behavior is enabled.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileIdleDelay
The amount of time a VM will idle before it is shutdown if this behavior is enabled.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileNoConnectDelay
The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileShutdownOnDisconnect
Whether shutdown on disconnect is enabled

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileShutdownOnIdle
Whether a VM will get shutdown when it has idled for a period of time.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoShutdownProfileShutdownWhenNotConnected
Whether a VM will get shutdown when it hasn't been connected to after a period of time.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectionProfileClientRdpAccess
The enabled access level for Client Access over RDP.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectionProfileClientSshAccess
The enabled access level for Client Access over SSH.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectionProfileWebRdpAccess
The enabled access level for Web Access over RDP.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectionProfileWebSshAccess
The enabled access level for Web Access over SSH.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the lab.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceId
Image resource ID

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceOffer
The image offer if applicable.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferencePublisher
The image publisher

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceSku
The image SKU

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageReferenceVersion
The image version specified on creation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabPlanId
The ID of the lab plan.
Used during resource creation to provide defaults and acts as a permission container when creating a lab via labs.azure.com.
Setting a labPlanId on an existing lab provides organization..

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the lab that uniquely identifies it within containing lab account.
Used in resource URIs.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: LabName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfileLoadBalancerId
The external load balancer resource id

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfilePublicIPId
The external public IP resource id

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProfileSubnetId
The external subnet resource id

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NonAdminUserPassword
The password for the user.
This is required for the TemplateVM createOption.

```yaml
Type: System.Security.SecureString
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NonAdminUserUsername
The username to use when signing in to lab VMs.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterProfileActiveDirectoryGroupId
The AAD group ID which this lab roster is populated from.
Having this set enables AAD sync mode.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterProfileLmsInstance
The base URI identifying the lms instance.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterProfileLtiClientId
The unique id of the azure lab services tool in the lms.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterProfileLtiContextId
The unique context identifier for the lab in the lms.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterProfileLtiRosterEndpoint
The uri of the names and roles service endpoint on the lms for the class attached to this lab.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityProfileOpenAccess
Whether any user or only specified users can register to a lab.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuCapacity
If the SKU supports scale out/in then the capacity integer should be included.
If scale out/in is not possible for the resource this may be omitted.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuFamily
If the service has different generations of hardware, for the same SKU, then that can be captured here.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuName
The name of the SKU.
Ex - P3.
It is typically a letter+number code

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuSize
The SKU size.
When the name field is the combination of tier and some other value, this would be the standalone code.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuTier
This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
The title of the lab.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineProfileCreateOption
Indicates what lab virtual machines are created from.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineProfileUsageQuota
The initial quota alloted to each lab user.
Must be a time span between 0 and 9999 hours.

```yaml
Type: System.TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualMachineProfileUseSharedPassword
Enabling this option will use the same password for all user VMs.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILab

## NOTES

## RELATED LINKS

