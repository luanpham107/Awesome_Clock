using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Unity;

namespace Awesome_Clock.App_Start
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Views.Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow?.Show();
        }
    }
}
