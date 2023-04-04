

using NoesisApp;
using System;
using System.Runtime.InteropServices;

namespace NoesisWpfBasicApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static AppContainer Container;

        [STAThread]
        private static void Main(string[] args)
        {
            Container = new AppContainer(new App());
            var app = Container.Resolve<App>().Value;

            //app.Uri = "App.xaml";
            //app.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

            
            app.Uri = "/NoesisWpfBasicApp;component/App.xaml";
            app.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

            app.Run();

        }
        protected override Display CreateDisplay()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                throw new Exception("Cannot continue ....");
            }
            else
            {
                return new Win32Display();
            }
        }

        // The result of CreateDisplay is stored in a public property on the base class,
        // but the result of CreateRenderContext is not, so store it here.
        internal RenderContext mainRenderContext;

        protected override RenderContext CreateRenderContext()
        {
            RenderContext result = PrivateCreateRenderContext();

            if (mainRenderContext == null) 
                mainRenderContext = result;

            return result;
        }

        private RenderContext PrivateCreateRenderContext()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                throw new Exception("Cannot continue ....");
            }
            else
            {
                return new RenderContextWGL();
            }
        }
    }
}
