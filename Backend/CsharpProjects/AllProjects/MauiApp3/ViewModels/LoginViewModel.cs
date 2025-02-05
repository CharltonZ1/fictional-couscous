namespace MauiApp3.ViewModels;

public partial class LoginViewModel : KeypadViewModel
{
    public LoginViewModel() : base("Please enter operator code") { }

    //[RelayCommand]
    //public override void OnSubmit()
    //{
    //    if (InputText == "1234")
    //    {
    //        PromptMessage = "Success!";
    //    }
    //    else
    //    {
    //        PromptMessage = "Invalid operator code";
    //    }
    //}
}
