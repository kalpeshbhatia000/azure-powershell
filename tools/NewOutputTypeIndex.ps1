param(
    [Parameter(Mandatory = $false)]
    [string] $BuildConfig = "Release",
    [Parameter(Mandatory = $false)]
    [string] $OutputFile = "outputtypes.json"
)

$AzPreviewPath = Get-Item "$PSScriptRoot\AzPreview\AzPreview.psd1"
Import-LocalizedData -BindingVariable ModuleMetadata -BaseDirectory $AzPreviewPath.DirectoryName -FileName $AzPreviewPath.Name
Get-ChildItem -Path "$PSScriptRoot\..\src" -Filter "*.psd1" -Recurse | Where-Object { $_.FullName -notlike "*autorest*" }
$OutputTypes = New-Object System.Collections.Generic.HashSet[string]

$ModuleMetadata.RequiredModules | ForEach-Object {
    $ModuleName = $_.ModuleName
    $SrcFile = $ModuleManifestFile | Where-Object { $_.Name -eq "$ModuleName.psd1" }
    Import-LocalizedData -BindingVariable SrcMetadata -BaseDirectory $SrcFile.DirectoryName -FileName $SrcFile.Name
    $NestedModules = $SrcMetadata.NestedModules | Where-Object { $_ -like "*.dll" }

    if ($NestedModules.Count -gt 0) {
        if (Test-Path "$PSScriptRoot\..\artifacts\$BuildConfig\$ModuleName\$ModuleName.psd1") {
            Import-Module "$PSScriptRoot\..\artifacts\$BuildConfig\$ModuleName\$ModuleName.psd1" 
        } else {
            Import-Module $ModuleName
        }

        $Module = Get-Module $ModuleName
        foreach ($ModuleInfo in $Module.NestedModules) {
            if ($SrcMetadata.NestedModules -contains "$($ModuleInfo.Name).dll") {
                foreach ($Cmdlet in $ModuleInfo.ExportedCmdlets.Values) {
                    $Cmdlet.ImplementingType.GetTypeInfo().GetCustomAttributes([System.Management.Automation.OutputTypeAttribute], $true) | ForEach-Object {
                        $_.Type.Name | ForEach-Object { $OutputTypes.Add($_) | Out-Null }
                    }

                    $Cmdlet.Parameters.Values | Where-Object { $_.Attributes.TypeId.FullName -contains "System.Management.Automation.ParameterAttribute" } | ForEach-Object {
                        $ParameterTypeFullName = $_.ParameterType.FullName
                        if ($ParameterTypeFullName -like "*System.Nullable*``[``[*") {
                            $OutputTypes.Add(($_.ParameterType.BaseType.FullName -replace "[][]", "")) | Out-Null
                        } elseif ($ParameterTypeFullName -notlike "*``[``[*") {
                            $OutputTypes.Add(($ParameterTypeFullName -replace "[][]", "")) | Out-Null
                        }
                    }
                }
            }
        }
    }
}

Write-Host "OutputTypes successfully created: $OutputFile." -ForegroundColor Green;

$OutputTypes | ConvertTo-Json | Out-File $OutputFile