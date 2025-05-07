using System.Windows.Input;

namespace ROIStaffDirectoryApp.Views;
public partial class LoginPage : ContentPage
{
    public ICommand NavigateToSignUpCommand { get; }

    public LoginPage()
    {
        InitializeComponent();

        NavigateToSignUpCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync("SignUpPage");
        });



        BindingContext = this;
    }
 
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigate to WelcomePage directly
        await Shell.Current.GoToAsync("WelcomePage");
    }

}

