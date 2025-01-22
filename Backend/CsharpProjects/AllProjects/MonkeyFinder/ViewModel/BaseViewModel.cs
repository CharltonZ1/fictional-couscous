namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;

    //public bool IsBusy
    //{
    //    get => isBusy;
    //    set
    //    {
    //        if (isBusy == value)
    //            return;
    //        isBusy = value;
    //        onPropertyChanged();
    //        onPropertyChanged(nameof(IsNotBusy));
    //    }
    //}

    //public bool IsNotBusy => !IsBusy;

    //public string Title
    //{
    //    get => title;
    //    set
    //    {
    //        if (title == value)
    //            return;
    //        title = value;
    //        onPropertyChanged();
    //    }
    //}

    //public event PropertyChangedEventHandler? PropertyChanged;

    //public void onPropertyChanged([CallerMemberName]string? name = null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //}
}
