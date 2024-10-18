using System;

namespace ClassActV._0._01.Views.Club_pages;

public partial class ClubNotifications : ContentPage
{
	public ClubNotifications()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("ClubManagerPage");
        return true;
    }
}