using KB12796_WpfApp1.Infrastructure;
using KB12796_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB12796_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<VisitorProfile> _visitorProfiles;

    public ObservableCollection<VisitorProfile> VisitorProfiles
    {
        get { return _visitorProfiles; }
        set { _visitorProfiles = value; OnPropertyChanged(); }
    }

    public double Average
    {
        get => _visitorProfiles.Average(profile => profile.NumberOfVisitors);
    }


    public MainWindowViewModel()
    {
        _visitorProfiles = new()
        {
            new() { AgeRange = "0-9", NumberOfVisitors = 10 },
            new() { AgeRange = "10-19", NumberOfVisitors = 29 },
            new() { AgeRange = "20-29", NumberOfVisitors = 38 },
            new() { AgeRange = "30-39", NumberOfVisitors = 20 },
            new() { AgeRange = "40-49", NumberOfVisitors = 18 },
            new() { AgeRange = "50-59", NumberOfVisitors = 17 },
            new() { AgeRange = "60-69", NumberOfVisitors = 15 },
            new() { AgeRange = "70-79", NumberOfVisitors = 10 },
            new() { AgeRange = "80以上", NumberOfVisitors = 4 },
        };
    }
}
