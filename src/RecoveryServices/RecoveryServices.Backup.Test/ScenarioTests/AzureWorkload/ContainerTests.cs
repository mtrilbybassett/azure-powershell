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

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Test.ScenarioTests
{
    public partial class ContainerTests : RecoveryServicesBackupTestRunner
    {
        private readonly string _AzureWorkloadcommonModule = $"ScenarioTests/{PsBackupProviderTypes.AzureWorkload}/Common.ps1";
        private readonly string _AzureWorkloadtestModule = $"ScenarioTests/{PsBackupProviderTypes.AzureWorkload}/ContainerTests.ps1";

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVmWorkload)]
        public void GetAzureVmWorkloadContainer()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureWorkloadcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureWorkloadtestModule.AsAbsoluteLocation()}",
                "Get-AzureVmWorkloadContainer"
            );
        }

        [Fact(Skip = "To be fixed in upcoming release")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVmWorkload)]
        public void UnregisterAzureWorkloadContainer()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureWorkloadcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureWorkloadtestModule.AsAbsoluteLocation()}",
                "Unregister-AzureWorkloadContainer"
            );
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVmWorkload)]
        public void TestAzureVmWorkloadUnDeleteContainer()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureWorkloadcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureWorkloadtestModule.AsAbsoluteLocation()}",
                "Test-AzureVmWorkloadUnDeleteContainer"
            );
        }

        [Fact(Skip = "The test is broken and waiting for a fix.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(TestConstants.Workload, TestConstants.AzureVmWorkload)]
        public void TestSQLContainerRegError()
        {
            TestRunner.RunTestScript(
                $"Import-Module {_AzureWorkloadcommonModule.AsAbsoluteLocation()}",
                $"Import-Module {_AzureWorkloadtestModule.AsAbsoluteLocation()}",
                "Test-SQLContainerRegError"
            );
        }
    }
}
