using Phoneword.Core;

namespace Phoneword
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string? translatedNumber;

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                // TODO:
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                // TODO:
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }

        }

        async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                try
                {
                    if (PhoneDialer.Default.IsSupported && !string.IsNullOrWhiteSpace(translatedNumber))
                    {
                        PhoneDialer.Default.Open(translatedNumber);
                    }
                }
                catch (Exception)
                {
                    await DisplayAlert("Unable to make the call", "Please try again.", "OK");
                }
            }
        }
    }

}
