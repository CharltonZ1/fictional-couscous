using MonkeyFinder.Services;
using MonkeyFinder.View;
using System.Diagnostics;
namespace MonkeyFinder.ViewModel;

public partial class MainViewModel : BaseViewModel
{
    MonkeyService monkeyService;
    public ObservableCollection<Monkey> Monkeys { get; } = [];

    public MainViewModel(MonkeyService monkeyService)
    {
        Title = "Monkey Finder";
        this.monkeyService = monkeyService;
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
    async Task GetMonkeyAsync()
    {
        if (IsBusy)
            return;

        try
        {
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
        }
    }
}
