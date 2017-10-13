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

using Microsoft.Azure.Commands.SubscriptionDefinition.Test.ScenarioTests.ScenarioTest;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.SubscriptionDefinition.Test.ScenarioTests
{
    public class SubscriptionDefinitionTests
    {
        private ServiceManagemenet.Common.Models.XunitTracingInterceptor _logger;

        public SubscriptionDefinitionTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new ServiceManagemenet.Common.Models.XunitTracingInterceptor(output);
            ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(_logger);
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListSubscriptionDefinitions()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListSubscriptionDefinitions");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetSubscriptionDefinitionInGroupScope()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-GetSubscriptionDefinitionInGroupScope");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetSubscriptionDefinitionInSubscriptionScope()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-GetSubscriptionDefinitionInSubscriptionScope");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewSubscriptionDefinition()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-NewSubscriptionDefinition");
        }
    }
}
