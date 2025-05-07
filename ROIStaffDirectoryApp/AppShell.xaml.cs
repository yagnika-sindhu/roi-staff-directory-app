using ROIStaffDirectoryApp.Views;
namespace ROIStaffDirectoryApp

{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("SignUpPage", typeof(SignUpPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("WelcomePage", typeof(WelcomePage));
            Routing.RegisterRoute("StaffDirectoryPage", typeof(StaffDirectoryPage));
            Routing.RegisterRoute("StaffProfilePage", typeof(StaffProfilePage));


        }
    }
}
