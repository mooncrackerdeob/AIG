using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace TidalSurge.Views;

public sealed partial class SplashPage : Page
{
    public SplashPage()
    {
        this.InitializeComponent();
        var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(1200) };
        timer.Tick += (s, e) =>
        {
            timer.Stop();
            Frame?.Navigate(typeof(AuthPage));
        };
        timer.Start();
    }
}

