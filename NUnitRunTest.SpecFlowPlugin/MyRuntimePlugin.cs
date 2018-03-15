using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using TechTalk.SpecFlow.Plugins;

namespace NUnitRunTest.SpecFlowPlugin
{
    public class MyRuntimePlugin : IRuntimePlugin
    {
        public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        {
            runtimePluginEvents.RegisterGlobalDependencies += OnRegisterGlobalDependencies;
        }

        private void OnRegisterGlobalDependencies(object sender, RegisterGlobalDependenciesEventArgs e)
        {
            var container = e.ObjectContainer;
            if (!container.IsRegistered<IMyDependency>())
            {
                var dependency = new MyDependency();
                container.RegisterInstanceAs<IMyDependency>(dependency);
            }
        }
    }
}
