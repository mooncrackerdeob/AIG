using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace TidalSurge;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        ContentFrame.Navigate(typeof(Views.SplashPage));
        NavList.SelectedIndex = 0;
    }

    private void OnNavSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (NavList.SelectedItem is ListViewItem item)
        {
            switch (item.Content?.ToString())
            {
                case "Master Control":
                    ContentFrame.Navigate(typeof(Views.DashboardPage));
                    break;
                case "Macros":
                    ContentFrame.Navigate(typeof(Views.MacrosPage));
                    break;
                case "Custom Macros (AI)":
                    ContentFrame.Navigate(typeof(Views.CustomMacrosPage));
                    break;
                case "Settings":
                    ContentFrame.Navigate(typeof(Views.SettingsPage));
                    break;
            }
        }
    }
}

