using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
namespace ROIStaffDirectoryApp.Views;

public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
        StartApp();
    }

    private async void StartApp()
    {
        await Task.Delay(2500); // 2.5 seconds delay

        // Navigate to LoginPage using Shell route
        await Shell.Current.GoToAsync("//LoginPage");
    }
}
