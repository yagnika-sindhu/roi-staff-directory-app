namespace ROIStaffDirectoryApp.Views;

using System.Windows.Input;

   public partial class SignUpPage : ContentPage
    {
        public ICommand NavigateToLoginCommand { get; }

        public SignUpPage()
        {
            InitializeComponent();

            NavigateToLoginCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("//LoginPage");
            });

            BindingContext = this;
        }
    }
