using MonkeyFinder.Services;
using MonkeyFinder.View;
using System.Diagnostics;
namespace MonkeyFinder.ViewModel;

public partial class MainViewModel : BaseViewModel
{
    readonly MonkeyService monkeyService;
    public ObservableCollection<Monkey> Monkeys { get; } = [];

    readonly IConnectivity connectivity;
    readonly IGeolocation geolocation;

    [ObservableProperty]
    bool isRefreshing;

    public bool IsBusyAndNotRefreshing => IsBusy && !IsRefreshing;

    public MainViewModel(MonkeyService monkeyService, IConnectivity connectivity, IGeolocation geolocation)
    {
        Title = "Monkey Finder";
        this.monkeyService = monkeyService;
        this.connectivity = connectivity;
        this.geolocation = geolocation;

        //connectivity = DependencyService.Get<IConnectivity>();
    }

    [RelayCommand]
    async Task GetClosestMonkey()
    {
        if(IsBusy || Monkeys.Count == 0)
            return;

        try
        {
            var location = await geolocation.GetLastKnownLocationAsync();

            location ??= await geolocation.GetLocationAsync(
                    new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30),

                    });

            if (location is null)
                return;

            var closest = Monkeys.OrderBy(m => location.CalculateDistance(m.Latitude, m.Longitude, DistanceUnits.Kilometers))
                .FirstOrDefault();

            if (closest is null)
                return;

            await Shell.Current.DisplayAlert("Closest Monkey", $"The closest monkey is {closest.Name} in {closest.Location}", "OK");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get closest monkey: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", $"Failed to retreive closest monkey: {ex.Message}", "OK");
        }
    }

    [RelayCommand]
    async Task GoToDetailsAsync(Monkey monkey)
    {
        if (monkey is null)
            return;

        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
            new Dictionary<string, object>()
            {
                {"Monkey", monkey }
            });
    }

    [RelayCommand]
    async Task GetMonkeysAsync()
    {
        if (IsBusy)
            return;

        try
        {

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No Connection", "No internet connection", "OK");
                return;
            }

            IsBusy = true;
            var monkeys = await monkeyService.GetMonkeys();

            if (monkeys?.Count > 0)
            {
                Monkeys.Clear();
                foreach (var monkey in monkeys)
                {
                    Monkeys.Add(monkey);
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", $"Failed to retreive monkeys: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }
}
