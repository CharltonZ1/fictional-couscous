namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class DetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    Monkey monkey;

    public DetailsViewModel()
    {
        Title = "Details";
    }
}
