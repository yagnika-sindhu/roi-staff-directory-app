using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using ROIStaffDirectoryApp.Models;
using System.Collections.ObjectModel;

namespace ROIStaffDirectoryApp.Views;

public partial class StaffDirectoryPage : ContentPage
{
    private ObservableCollection<Staff> AllStaff;

    public StaffDirectoryPage()
    {
        InitializeComponent();

        AllStaff = new ObservableCollection<Staff>
        {
            new Staff { Id = 1, Name = "John Smith", Phone = "02 9988 2211", Email = "John.smith@gmail.com", Department = "Information Communications Technology", Address = "1 Code Lane, Javaville, NSW 0100, Australia" },
            new Staff { Id = 2, Name = "Sue White", Phone = "03 8899 2255", Email = "Sue.white@gmail.com", Department = "Finance", Address = "16 Bit Way, Byte Cove, QLD 1101, Australia" },
            new Staff { Id = 3, Name = "Bob O’Bits", Phone = "05 7788 2255", Email = "Bob.bits@gmail.com", Department = "Marketing", Address = "8 Silicon Road, Cloud Hills, VIC 1001, Australia" },
            new Staff { Id = 4, Name = "Mary Blue", Phone = "06 4455 9988", Email = "Mary.blue@gmail.com", Department = "Finance", Address = "4 Processor Boulevard, Appletson, NT 1010, Australia" },
            new Staff { Id = 5, Name = "Mick Green", Phone = "02 9988 1122", Email = "Mick.green@gmail.com", Department = "Marketing", Address = "700 Bandwidth Street, Bufferland, NSW 0110, Australia" }
        };

        StaffList.ItemsSource = AllStaff;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var query = e.NewTextValue?.ToLower() ?? "";
        StaffList.ItemsSource = AllStaff.Where(s =>
            s.Name.ToLower().Contains(query) ||
            s.Department.ToLower().Contains(query));
    }

    private async void OnStaffSelected(object sender, SelectionChangedEventArgs e)
    {
        var selected = e.CurrentSelection.FirstOrDefault() as Staff;
        if (selected == null) return;

        // Optional: Clear navigation stack to prevent caching issues
        await Shell.Current.GoToAsync("//StaffDirectoryPage");

        // Build the query string with properly encoded values
        var route = $"StaffProfilePage?" +
                    $"Name={Uri.EscapeDataString(selected.Name)}&" +
                    $"Phone={Uri.EscapeDataString(selected.Phone)}&" +
                    $"Email={Uri.EscapeDataString(selected.Email)}&" +
                    $"Department={Uri.EscapeDataString(selected.Department)}&" +
                    $"Address={Uri.EscapeDataString(selected.Address)}";

        // Navigate with forced query update
        await Shell.Current.GoToAsync(route, true);

        ((CollectionView)sender).SelectedItem = null; // clear selection
    }


}

