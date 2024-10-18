namespace ClassActV._0._01.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    //start to routing to pages - buttons
    private async void Club_Page_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ClubManagerPage");
    }
    private async void Classwork_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("classWork");
    }
    private async void Reminder_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Reminders");
    }
    private async void Notes_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AllNotesPage");
    }
    private async void SchoolEvents_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("schoolEventsPage");
    }
    private async void Email_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("emailPage");
    }

    //end of the routing to pages - buttons
}
