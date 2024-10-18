using ClassActV._0._01.Views.Club_pages;

namespace ClassActV._0._01.Views;

public partial class ClubManagerPage : ContentPage
{
	public ClubManagerPage()
	{
		InitializeComponent();
	}

	private async void Club_Notification_Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ClubNotifications());
	}
    private async void Your_Clubs_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new YourClubs());
    }
}