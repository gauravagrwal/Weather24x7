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

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            AppCurrentVersion.Text = $"version {VersionTracking.CurrentVersion}";
        }
    }
}
