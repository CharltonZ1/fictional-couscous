using System.Diagnostics;

namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class DetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    Monkey monkey;

    readonly IMap map;

    public DetailsViewModel(IMap map)
    {
        Title = "Details";
        this.map = map;
    }

    [RelayCommand]
    async Task OpenMapAsync()
    {
        try
        {
            await map.OpenAsync(Monkey.Latitude, Monkey.Longitude,
                new MapLaunchOptions()
                {
                    Name = Monkey.Name,
                    NavigationMode = NavigationMode.None
                });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Unable to open maps", "OK");
        }
    }
}
