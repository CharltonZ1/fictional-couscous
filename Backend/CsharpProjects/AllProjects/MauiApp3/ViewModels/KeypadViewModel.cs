using AndroidApp = Android.App.Application;
using Setting = Android.Provider.Settings;
using static Android.Provider.Settings;

namespace MauiApp3.ViewModels;

public partial class KeypadViewModel : ObservableObject
{
    [ObservableProperty]
    string? inputText;

    [ObservableProperty]
    string? promptMessage;

    [ObservableProperty]
    string? batteryLevel;

    [ObservableProperty]
    string? batteryIcon;

    [ObservableProperty]
    string? signalIcon;

    [ObservableProperty]
    string? idDevice;

    public KeypadViewModel(string prompt)
    {
        PromptMessage = prompt;

        // Subscribe to battery level changes
        Battery.BatteryInfoChanged += OnBatteryInfoChanged;

        // Subscribe to connectivity changes
        Connectivity.ConnectivityChanged += OnConnectivityChanged;

        // Get Device Id
        GetDeviceId();

    }

    [RelayCommand]
    public void OnKeyPress(string key)
    {
        if (InputText == null)
        {
            InputText = key;
        }
        else
        {
            InputText += key;
        }
    }

    [RelayCommand]
    public void OnBackspace()
    {
        if (InputText != null && InputText.Length > 0)
        {
            InputText = InputText[..^1];
        }
    }

    [RelayCommand]
    public void OnClear()
    {
        InputText = null;
    }

    [RelayCommand]
    public void OnSubmit()
    {
        //PromptMessage = $"Submitted: {InputText}";
        InputText = $"Submitted: {InputText}";
    }

    void OnBatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
    {
        BatteryLevel = $"{(int)(e.ChargeLevel * 100)}%";

        UpdateBatteryIcon(e.State);
    }

    void UpdateBatteryIcon(BatteryState state)
    {
        if (state == BatteryState.Charging)
        {
            BatteryIcon = "battery_charging_ico.png";
        }
        else
        {
            BatteryIcon = "battery_full_ico.png";
        }
    }

    void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
    {
        var profiles = Connectivity.Current.ConnectionProfiles;

        if (profiles.Contains(ConnectionProfile.WiFi))
        {
            SignalIcon = "wifi_ico.png";
        }
        else if (profiles.Contains(ConnectionProfile.Cellular))
        {
            SignalIcon = "mobile_signal.ico"; 
        }
        else
        {
            SignalIcon = "no_signal_ico.png";
        }
    }

    void GetDeviceId()
    {
        //var context = Platform.CurrentActivity;

        //string? deviceId = Android.Provider.Settings.Secure.GetString(context?.ContentResolver, Android.Provider.Settings.Secure.AndroidId);


        var context = AndroidApp.Context;
        IdDevice = Setting.Secure.GetString(context.ContentResolver, Secure.AndroidId) ?? "Unknown"; 
    }
}
