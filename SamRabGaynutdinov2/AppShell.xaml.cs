namespace SamRabGaynutdinov2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(AddTrainingPage), typeof(AddTrainingPage));
        }
    }
}
