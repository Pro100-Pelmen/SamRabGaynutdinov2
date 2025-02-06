using SamRabGaynutdinov2.DatabaseContent;


namespace SamRabGaynutdinov2
{
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginUser(object sender, EventArgs e)
        {
            var login = LoginEntry.Text;
            var password = PasswordEntry.Text;

            ApplicationDbContext dbContext = new ApplicationDbContext();

            var user = dbContext.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
            if (user == null)
            {
                AppShell.Current.DisplayAlert("Ошибка", "Пользователь или пароль неверны", "OK");
                return;
            }

            ApplicationData.CurrentUser = user;
            AppShell.Current.GoToAsync("//" + nameof(MenuPage), true);
        }

        private void GoToRegistrarionPage(object sender, TappedEventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(RegistrationPage), true);
        }
    }

}
