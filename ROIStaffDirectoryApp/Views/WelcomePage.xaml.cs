namespace ROIStaffDirectoryApp.Views;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void OnStaffDirectoryClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StaffDirectoryPage");
    }
}
