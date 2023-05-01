namespace MauiApp2;

public partial class LoginPage : ContentPage
{

    private string login;
    private string password;

    public LoginPage()
	{
		InitializeComponent();
	}
    private async void OnLoginButtonClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChatPage());
    }
    private async void OnSignUpButtonClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}