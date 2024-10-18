namespace ClassActV._0._01.Views.Club_pages;

public partial class YourClubs : ContentPage
{
	public YourClubs()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("..");
        return true;
    }
}