using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp2.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string? text;

    IConnectivity connectivity;

    public MainViewModel(IConnectivity connectivity)
    {
        items = [];
        this.connectivity = connectivity;
    }

    [RelayCommand]
    async Task Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        if (connectivity.NetworkAccess != NetworkAccess.Internet)
        {
            await Shell.Current.DisplayAlert("No Internet", "You need to be connected to the internet to add items.", "OK");
            return;
        }

        Items.Add(Text);
        // add our item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string item)
    {
        Items.Remove(item);
    }

    [RelayCommand]
    async Task Tap(string item)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={item}");
    }

}
