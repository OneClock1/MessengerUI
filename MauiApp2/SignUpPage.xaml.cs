namespace MauiApp2;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	private void OnSignUpButtonClicked(object sender, EventArgs e)
	{

	}
    private async void OnLogInButtonClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}