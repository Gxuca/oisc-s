using DryIoc;
using OSIStudentSide.Config;
using OSIStudentSide.Http;
using OSIStudentSide.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace OSIStudentSide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<AppConfig>(() => ConfigFileHelper.InitAppConfig("./settings.json"));
            containerRegistry.RegisterScoped<HttpRestClient>();
        }

    }
}
