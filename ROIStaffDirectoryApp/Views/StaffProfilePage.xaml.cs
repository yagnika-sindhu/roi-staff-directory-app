using System.Xml;
using ROIStaffDirectoryApp.Models;

namespace ROIStaffDirectoryApp.Views;

[QueryProperty("Name", "Name")]
[QueryProperty("Phone", "Phone")]
[QueryProperty("Email", "Email")]
[QueryProperty("Department", "Department")]
[QueryProperty("Address", "Address")]
public partial class StaffProfilePage : ContentPage
{
    public string Name { set => nameLabel.Text = value; }
    public string Phone { set => phoneLabel.Text = value; }
    public string Email { set => emailLabel.Text = value; }
    public string Department { set => departmentLabel.Text = value; }
    public string Address { set => addressLabel.Text = value; }

    public StaffProfilePage()
    {
        InitializeComponent();
    }
}
