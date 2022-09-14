using Weather24x7.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Weather24x7
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(LocationsPage), typeof(LocationsPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

            AppCurrentVersion.Text = $"version {VersionTracking.CurrentVersion}";
        }
    }
}
