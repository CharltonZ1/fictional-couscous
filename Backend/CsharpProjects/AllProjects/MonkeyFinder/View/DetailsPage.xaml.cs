namespace MonkeyFinder.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}