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

using Microsoft.Azure.Commands.ScenarioTest.SqlTests;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Sql.Test.ScenarioTests
{
    public class TDECertificateTests : SqlTestsBase
    {
        public TDECertificateTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAddTdeCertificateForSqlServerDefaultParameterSetNoPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerDefaultParameterSetNoPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        // TODO: 6992 Improve test execution performance on NetCore
        [Trait(Category.RunType, Category.DesktopOnly)]
        public void TestAddTdeCertificateForSqlServerDefaultParameterSetWithPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerDefaultParameterSetWithPassword");
        }

        [Fact(Skip = "Skip due to long setup time for managed instance")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        // TODO: 6992 Improve test execution performance on NetCore
        [Trait(Category.RunType, Category.DesktopOnly)]
        public void TestAddTdeCertificateForManagedInstanceDefaultParameterSetNoPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForManagedInstanceDefaultParameterSetNoPassword");
        }

        [Fact(Skip = "Skip due to long setup time for managed instance")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAddTdeCertificateForManagedInstanceDefaultParameterSetWithPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForManagedInstanceDefaultParameterSetWithPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        // TODO: 6992 Improve test execution performance on NetCore
        [Trait(Category.RunType, Category.DesktopOnly)]
        public void TestAddTdeCertificateForSqlServerInputObjectParameterSetWithPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerInputObjectParameterSetWithPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAddTdeCertificateForSqlServerResourceIdParameterSetWithPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerResourceIdParameterSetWithPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        // TODO: 6992 Improve test execution performance on NetCore
        [Trait(Category.RunType, Category.DesktopOnly)]
        public void TestAddTdeCertificateForSqlServerInputObjectParameterSetNoPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerInputObjectParameterSetNoPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        // TODO: 6992 Improve test execution performance on NetCore
        [Trait(Category.RunType, Category.DesktopOnly)]
        public void TestAddTdeCertificateForSqlServerResourceIdParameterSetNoPassword()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerResourceIdParameterSetNoPassword");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAddTdeCertificateForSqlServerWithPiping()
        {
            RunPowerShellTest("Test-AddTdeCertificateForSqlServerWithPiping");
        }
    }
}
