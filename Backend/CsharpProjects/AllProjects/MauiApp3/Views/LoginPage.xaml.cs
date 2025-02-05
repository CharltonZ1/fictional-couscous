namespace MauiApp3.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel context)
	{
		InitializeComponent();
        BindingContext = context;
    }
}