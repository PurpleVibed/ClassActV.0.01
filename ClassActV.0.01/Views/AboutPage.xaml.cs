namespace ClassActV._0._01.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		var uri = new Uri("https://www.congressionalappchallenge.us/"); 
		await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
	}
}