using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shared;
using TechTalk.SpecFlow;

namespace NUnitTests
{
    [Binding]
    public class StepDefinitions
    {
        public StepDefinitions(IMyDependency dependency)
        {

        }

        [Given(@"The plugin has loaded correctly")]
        public void GivenThePluginHasLoadedCorrectly()
        {
            TestContext.Out.WriteLine(
                "This will never execute becuase the dependency in the constructor cannot " +
                "be resolved due to the plugin no being loaded.");
        }
    }
}
