// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Company information of the user to be passed to partners.</summary>
    public partial class CompanyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.ICompanyInfo,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.ICompanyInfoInternal
    {

        /// <summary>Backing field for <see cref="Business" /> property.</summary>
        private string _business;

        /// <summary>Business of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Business { get => this._business; set => this._business = value; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country of the company location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="EmployeesNumber" /> property.</summary>
        private string _employeesNumber;

        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string EmployeesNumber { get => this._employeesNumber; set => this._employeesNumber = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of the company location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="CompanyInfo" /> instance.</summary>
        public CompanyInfo()
        {

        }
    }
    /// Company information of the user to be passed to partners.
    public partial interface ICompanyInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Business of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Business of the company",
        SerializedName = @"business",
        PossibleTypes = new [] { typeof(string) })]
        string Business { get; set; }
        /// <summary>Country of the company location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country of the company location.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>Domain of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domain of the company",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }
        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of employees in the company",
        SerializedName = @"employeesNumber",
        PossibleTypes = new [] { typeof(string) })]
        string EmployeesNumber { get; set; }
        /// <summary>State of the company location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the company location.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

    }
    /// Company information of the user to be passed to partners.
    internal partial interface ICompanyInfoInternal

    {
        /// <summary>Business of the company</summary>
        string Business { get; set; }
        /// <summary>Country of the company location.</summary>
        string Country { get; set; }
        /// <summary>Domain of the company</summary>
        string Domain { get; set; }
        /// <summary>Number of employees in the company</summary>
        string EmployeesNumber { get; set; }
        /// <summary>State of the company location.</summary>
        string State { get; set; }

    }
}