using demoMAUI.Code.Views;

namespace demoMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // registramos todos las rutas
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("home", typeof(HomePage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));
        }
    }
}
