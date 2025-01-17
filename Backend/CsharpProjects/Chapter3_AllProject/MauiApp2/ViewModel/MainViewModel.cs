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

    public MainViewModel()
    {
        items = [];
    }

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        // add our item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string item)
    {
        Items.Remove(item);
    }

}
