using StrongInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoesisWpfBasicApp
{
    internal partial class AppContainer : IContainer<App>
    {
        [Instance] 
        private App Application;
        public AppContainer(App application)
        {
            Application = application;
        }
    }
}
