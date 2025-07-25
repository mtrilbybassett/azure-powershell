---
external help file: Az.Cdn-help.xml
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/az.cdn/get-azfrontdoorcdnroute
schema: 2.0.0
---

# Get-AzFrontDoorCdnRoute

## SYNOPSIS
Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.

## SYNTAX

### List (Default)
```
Get-AzFrontDoorCdnRoute -EndpointName <String> -ProfileName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentityProfile
```
Get-AzFrontDoorCdnRoute -EndpointName <String> -Name <String> -ProfileInputObject <ICdnIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzFrontDoorCdnRoute -EndpointName <String> -Name <String> -ProfileName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentityAfdEndpoint
```
Get-AzFrontDoorCdnRoute -Name <String> -AfdEndpointInputObject <ICdnIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzFrontDoorCdnRoute -InputObject <ICdnIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint.

## EXAMPLES

### Example 1: List AzureFrontDoor routes under the AzureFrontDoor profile
```powershell
Get-AzFrontDoorCdnRoute -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end001
```

```output
Name     ResourceGroupName
----     -----------------
route001 testps-rg-da16jm
route002 testps-rg-da16jm
route003 testps-rg-da16jm
route004 testps-rg-da16jm
```

List AzureFrontDoor routes under the AzureFrontDoor profile

### Example 2: Get an AzureFrontDoor route under the AzureFrontDoor profile
```powershell
Get-AzFrontDoorCdnRoute -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end001 -Name route001
```

```output
Name     ResourceGroupName
----     -----------------
route001 testps-rg-da16jm
```

Get an AzureFrontDoor route under the AzureFrontDoor profile

### Example 3: Get an AzureFrontDoor route under the AzureFrontDoor profile via identity
```powershell
$originGroup = Get-AzFrontDoorCdnOriginGroup -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -OriginGroupName org001
$ruleSet = Get-AzFrontDoorCdnRuleSet -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -RuleSetName ruleset001
$customdomain = Get-AzFrontDoorCdnCustomDomain -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -CustomDomainName domain001

$ruleSetResource = New-AzFrontDoorCdnResourceReferenceObject -Id $ruleSet.Id
$customdomainResource = New-AzFrontDoorCdnResourceReferenceObject -Id $customdomain.Id

New-AzFrontDoorCdnRoute -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end001 -Name route001 -OriginGroupId $originGroup.Id -RuleSet @($ruleSetResource) -PatternsToMatch "/*" -LinkToDefaultDomain "Enabled" -EnabledState "Enabled" -CustomDomain @($customdomainResource) | Get-AzFrontDoorCdnRoute
```

```output
Name     ResourceGroupName
----     -----------------
route001 testps-rg-da16jm
```

Get an AzureFrontDoor route under the AzureFrontDoor profile via identity

## PARAMETERS

### -AfdEndpointInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
Parameter Sets: GetViaIdentityAfdEndpoint
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -EndpointName
Name of the endpoint under the profile which is unique globally.

```yaml
Type: System.String
Parameter Sets: List, GetViaIdentityProfile, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Name of the routing rule.

```yaml
Type: System.String
Parameter Sets: GetViaIdentityProfile, Get, GetViaIdentityAfdEndpoint
Aliases: RouteName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
Parameter Sets: GetViaIdentityProfile
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ProfileName
Name of the Azure Front Door Standard or Azure Front Door Premium which is unique within the resource group.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the Resource group within the Azure subscription.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Azure Subscription ID.

```yaml
Type: System.String[]
Parameter Sets: List, Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRoute

## NOTES

## RELATED LINKS
