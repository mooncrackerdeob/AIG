using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace TidalSurge.Views;

public sealed partial class AuthPage : Page
{
    public AuthPage()
    {
        this.InitializeComponent();
    }

    private async void OnActivateClick(object sender, RoutedEventArgs e)
    {
        ActivateButton.IsEnabled = false;
        ActivateSpinner.IsActive = true;
        ActivateSpinner.Visibility = Visibility.Visible;
        StatusText.Text = "Verifying key…";

        // Simulate verification and HWID binding
        await Task.Delay(1200);

        // In real app, perform network call and machine binding here
        StatusText.Text = "Activation Successful. Welcome!";
        await Task.Delay(800);
        Frame?.Navigate(typeof(DashboardPage));
    }
}

