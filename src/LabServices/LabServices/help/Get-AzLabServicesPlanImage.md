---
external help file: Az.LabServices-help.xml
Module Name: Az.LabServices
online version: https://learn.microsoft.com/powershell/module/az.labservices/get-azlabservicesplanimage
schema: 2.0.0
---

# Get-AzLabServicesPlanImage

## SYNOPSIS
Gets an image resource.

## SYNTAX

### ResourceId (Default)
```
Get-AzLabServicesPlanImage [-SubscriptionId <String[]>] -ResourceId <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### ListByDisplayName
```
Get-AzLabServicesPlanImage -LabPlanName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 -DisplayName <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List
```
Get-AzLabServicesPlanImage -LabPlanName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-Filter <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzLabServicesPlanImage -LabPlanName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### LabPlan
```
Get-AzLabServicesPlanImage [-Name <String>] [-SubscriptionId <String[]>] -LabPlan <LabPlan>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentityLabPlan
```
Get-AzLabServicesPlanImage -Name <String> -LabPlanInputObject <ILabServicesIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzLabServicesPlanImage -InputObject <ILabServicesIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets an image resource.

## EXAMPLES

### Example 1: Get all image in the lab plan.
```powershell
Get-AzLabServicesPlanImage -LabPlanName "Plan Name" -ResourceGroupName "Group Name"
```

```output
Name
----
128technology.128t_networking_platform.128t_networking_platform
128technology.128technology_conductor_hourly.128technology_conductor_hourly_427
128technology.128technology_conductor_hourly.128technology_conductor_hourly_452
```

Gets all the available images, this is usually a long list of images.

### Example 2: Get specific image in the lab plan.
```powershell
Get-AzLabServicesPlanImage -LabPlanName "Plan Name"  -ResourceGroupName "Group Name" -Name 'canonical.0001-com-ubuntu-server-focal.20_04-lts'
```

```output
Name
----
canonical.0001-com-ubuntu-server-focal.20_04-lts
```

Returns the specific image.

### Example 3: Get specific image using display name.
```powershell
Get-AzLabServicesPlanImage -LabPlanName "Plan Name" -ResourceGroupName "Group Name" -DisplayName 'Ubuntu Server 20.04 LTS'
```

```output
Name
----
canonical.0001-com-ubuntu-server-focal.20_04-lts
```

Returns the specific image with the display name.

## PARAMETERS

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

### -DisplayName
The image display name.

```yaml
Type: System.String
Parameter Sets: ListByDisplayName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
The filter to apply to the operation.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabServicesIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LabPlan
The object of lab service lab plan to get images for.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlan
Parameter Sets: LabPlan
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LabPlanInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabServicesIdentity
Parameter Sets: GetViaIdentityLabPlan
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LabPlanName
The name of the lab plan that uniquely identifies it within containing resource group.
Used in resource URIs and in UI.

```yaml
Type: System.String
Parameter Sets: ListByDisplayName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The image name.

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentityLabPlan
Aliases: ImageName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: System.String
Parameter Sets: LabPlan
Aliases: ImageName

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
Parameter Sets: ListByDisplayName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceId
The resource Id of lab service lab plan.

```yaml
Type: System.String
Parameter Sets: ResourceId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: ResourceId, ListByDisplayName, List, Get, LabPlan
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

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.ILabServicesIdentity

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.LabPlan

### System.String

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IImage

## NOTES

## RELATED LINKS
