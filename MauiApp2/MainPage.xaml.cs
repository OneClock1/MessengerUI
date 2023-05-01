namespace MauiApp2;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnLogInButtonClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
    private async void OnSignUpButtonClickedAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }



}

