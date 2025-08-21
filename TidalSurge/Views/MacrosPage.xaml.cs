using Microsoft.UI.Xaml.Controls;

namespace TidalSurge.Views;

public sealed partial class MacrosPage : Page
{
    public MacrosPage()
    {
        this.InitializeComponent();
    }

    private void OnMacroSelected(object sender, SelectionChangedEventArgs e)
    {
        if (MacroList.SelectedItem is ListViewItem item)
        {
            MacroTitle.Text = item.Content?.ToString() ?? "Macro";
        }
    }
}

