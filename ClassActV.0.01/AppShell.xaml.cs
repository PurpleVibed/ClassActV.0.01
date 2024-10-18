using ClassActV._0._01.Views;
using ClassActV._0._01.Views.Club_pages;

namespace ClassActV._0._01
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //DONT TOUCH, IF YOU TOUCH IT EVERYTHING BREAKS ->
            Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
            //DONT TOUCH, IF YOU TOUCH IT EVERYTHING BREAKS <-

            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("schoolEventsPage", typeof(schoolEventsPage));
            Routing.RegisterRoute("emailPage", typeof(emailPage));
            Routing.RegisterRoute("classWork", typeof(classWork));
            Routing.RegisterRoute("information", typeof(information));
            Routing.RegisterRoute("AllNotesPage", typeof(AllNotesPage));
            Routing.RegisterRoute("Reminders", typeof(Reminders));
            Routing.RegisterRoute("AboutPage", typeof(AboutPage));
            Routing.RegisterRoute("ClubManagerPage", typeof(ClubManagerPage));

            Routing.RegisterRoute("ClubNotifications", typeof(ClubNotifications));
            Routing.RegisterRoute("YourClubs", typeof(YourClubs));


            //Routing.RegisterRoute("", typeof());
        }
        //Homepage
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        { 
            await Shell.Current.GoToAsync("///MainPage");
        }

        
    }
}
