// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>a powershell credential object</summary>
    public partial class PsCredentialExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPsCredentialExecutionParameter,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPsCredentialExecutionParameterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter __scriptExecutionParameter = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptExecutionParameter();

        /// <summary>The parameter name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name = value ; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>password for login</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>The type of execution parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Type = value ; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>username for login</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="PsCredentialExecutionParameter" /> instance.</summary>
        public PsCredentialExecutionParameter()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
            await eventListener.AssertObjectIsValid(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
        }
    }
    /// a powershell credential object
    public partial interface IPsCredentialExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter
    {
        /// <summary>password for login</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password for login",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>username for login</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"username for login",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// a powershell credential object
    internal partial interface IPsCredentialExecutionParameterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameterInternal
    {
        /// <summary>password for login</summary>
        string Password { get; set; }
        /// <summary>username for login</summary>
        string Username { get; set; }

    }
}