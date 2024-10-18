namespace ClassActV._0._01.Views;

public partial class emailPage : ContentPage
{
	public emailPage()
	{
		InitializeComponent();
	}

	private async void School_Email_Button_Clicked(object sender, EventArgs e)
	{
		var uri = new Uri("https://mail.google.com/mail/u/2/#inbox");
		await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
    private async void Personal_Email_Button_Clicked(object sender, EventArgs e)
    {
        var uri = new Uri("https://mail.google.com/mail/u/1/#inbox");
        await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }

}