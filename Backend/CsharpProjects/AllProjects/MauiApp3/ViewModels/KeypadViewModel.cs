namespace MauiApp3.ViewModels;

public partial class KeypadViewModel : ObservableObject
{
    [ObservableProperty]
    string? inputText;

    [ObservableProperty]
    string? promptMessage;

    public KeypadViewModel(string prompt)
    {
        PromptMessage = prompt;
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
}
