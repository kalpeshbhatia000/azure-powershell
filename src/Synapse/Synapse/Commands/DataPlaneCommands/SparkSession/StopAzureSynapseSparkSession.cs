﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsLifecycle.Stop, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.SparkSession, DefaultParameterSetName = DeleteByIdParameterSet, SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public class StopAzureSynapseSparkSession : SynapseSparkCmdletBase
    {
        private const string DeleteByIdParameterSet = "DeleteByNameParameterSet";
        private const string DeleteByParentObjectParameterSet = "DeleteByParentObjectParameterSet";
        private const string DeleteByInputObjectParameterSet = "DeleteByInputObjectParameterSet";

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = DeleteByIdParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public override string WorkspaceName { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = DeleteByIdParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.SparkPoolName)]
        [ResourceNameCompleter(
            ResourceTypes.SparkPool,
            "ResourceGroupName",
            nameof(WorkspaceName))]
        [ValidateNotNullOrEmpty]
        public override string SparkPoolName { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = DeleteByIdParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.SessionId)]
        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = DeleteByParentObjectParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.SessionId)]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        public int LivyId { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = DeleteByParentObjectParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.SparkPoolObject)]
        [ValidateNotNull]
        public PSSynapseSparkPool SparkPoolObject { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = DeleteByInputObjectParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.SessionObject)]
        [ValidateNotNull]
        public PSSynapseSparkSession InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.PassThru)]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJob)]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.SparkPoolObject))
            {
                var resourceIdentifier = new ResourceIdentifier(this.SparkPoolObject.Id);
                this.WorkspaceName = resourceIdentifier.ParentResource;
                this.WorkspaceName = this.WorkspaceName.Substring(this.WorkspaceName.LastIndexOf('/') + 1);
                this.SparkPoolName = resourceIdentifier.ResourceName;
            }

            if (this.IsParameterBound(c => c.InputObject))
            {
                this.WorkspaceName = this.InputObject.WorkspaceName;
                this.SparkPoolName = this.InputObject.SparkPoolName;
                this.LivyId = this.InputObject.Id.Value;
            }

            if (this.ShouldProcess(this.LivyId.ToString(), string.Format(Resources.StoppingSynapseSparkSession, this.LivyId)))
            {
                this.SynapseAnalyticsClient.StopSparkSession(this.LivyId, waitForCompletion:false);
                if (this.PassThru.IsPresent)
                {
                    WriteObject(true);
                }
            }
        }
    }
}
