namespace MauiApp2;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
	}
    private void OnSendClicked(object sender, EventArgs e)
    {
        string message = messageEntry.Text;

        if (!string.IsNullOrWhiteSpace(message))
        {
            chatMessages.Children.Add(new Label { Text = message, Padding = new Thickness(10) });
            messageEntry.Text = string.Empty;
        }
    }
}