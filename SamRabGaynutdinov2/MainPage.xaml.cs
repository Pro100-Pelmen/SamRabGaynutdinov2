using SamRabGaynutdinov2.DatabaseContent;

namespace SamRabGaynutdinov2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginUser(object sender, EventArgs e)
        {

        }

        private void GoToRegistrarionPage(object sender, TappedEventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(RegistrationPage), true);
        }
    }

}
