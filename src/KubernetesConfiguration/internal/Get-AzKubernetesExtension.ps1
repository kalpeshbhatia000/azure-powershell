
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
Gets Kubernetes Cluster Extension.
.Description
Gets Kubernetes Cluster Extension.
.Example
PS C:\> Get-AzKubernetesExtension -ClusterName azpstest_cluster_arc -ClusterType ConnectedClusters -Name azpstest-extension -ResourceGroupName azpstest_gp

Name               ExtensionType           Version ProvisioningState AutoUpgradeMinorVersion ReleaseTrain
----               -------------           ------- ----------------- ----------------------- ------------
azpstest-extension azuremonitor-containers 2.9.2   Succeeded         True                    Stable
.Example
PS C:\> Get-AzKubernetesExtension -ClusterName azpstest_cluster_arc -ClusterType ConnectedClusters -ResourceGroupName azpstest_gp

Name               ExtensionType           Version ProvisioningState AutoUpgradeMinorVersion ReleaseTrain
----               -------------           ------- ----------------- ----------------------- ------------
azpstest-extension azuremonitor-containers 2.9.2   Succeeded         True                    Stable
flux               microsoft.flux          1.0.0   Succeeded         True                    Stable

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IKubernetesConfigurationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtension
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IKubernetesConfigurationIdentity>: Identity Parameter
  [ClusterName <String>]: The name of the kubernetes cluster.
  [ClusterResourceName <String>]: The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters.
  [ClusterRp <String>]: The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
  [ExtensionName <String>]: Name of the Extension.
  [FluxConfigurationName <String>]: Name of the Flux Configuration.
  [Id <String>]: Resource identity path
  [OperationId <String>]: operation Id
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SourceControlConfigurationName <String>]: Name of the Source Control Configuration.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://docs.microsoft.com/powershell/module/az.kubernetesconfiguration/get-azkubernetesextension
#>
function Get-AzKubernetesExtension {
[Alias('Get-AzK8sExtension')]
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IExtension])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [System.String]
    # The name of the kubernetes cluster.
    ${ClusterName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [System.String]
    # The Kubernetes cluster RP - i.e.
    # Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
    ${ClusterRp},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [System.String]
    # The Kubernetes cluster resource name - i.e.
    # managedClusters, connectedClusters, provisionedClusters.
    ${ClusterType},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ExtensionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [System.String]
    # Name of the Extension.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IKubernetesConfigurationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
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

        $mapping = @{
            Get = 'Az.KubernetesConfiguration.private\Get-AzKubernetesExtension_Get';
            GetViaIdentity = 'Az.KubernetesConfiguration.private\Get-AzKubernetesExtension_GetViaIdentity';
            List = 'Az.KubernetesConfiguration.private\Get-AzKubernetesExtension_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
