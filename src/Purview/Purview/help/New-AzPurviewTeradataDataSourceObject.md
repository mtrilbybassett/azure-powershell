---
external help file: Az.Purview-help.xml
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/Az.Purview/new-azpurviewteradatadatasourceobject
schema: 2.0.0
---

# New-AzPurviewTeradataDataSourceObject

## SYNOPSIS
Create an in-memory object for TeradataDataSource.

## SYNTAX

```
New-AzPurviewTeradataDataSourceObject [-CollectionReferenceName <String>] [-CollectionType <String>]
 [-Host <String>] [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for TeradataDataSource.

## EXAMPLES

### Example 1: Create Teradata data source object
```powershell
New-AzPurviewTeradataDataSourceObject -CollectionReferenceName 'parv-brs-2' -CollectionType 'CollectionReference' -Host '12.13.14.12'
```

```output
CollectionLastModifiedAt :
CollectionReferenceName  : parv-brs-2
CollectionType           : CollectionReference
CreatedAt                :
Host                     : 12.13.14.12
Id                       :
Kind                     : Teradata
LastModifiedAt           :
Name                     :
Scan                     :
```

Create Teradata data source object

## PARAMETERS

### -CollectionReferenceName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CollectionType

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Host

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

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

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TeradataDataSource

## NOTES

## RELATED LINKS
