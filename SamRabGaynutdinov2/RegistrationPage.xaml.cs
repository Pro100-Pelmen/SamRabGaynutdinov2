using SamRabGaynutdinov2.DatabaseContent;
using SamRabGaynutdinov2.Entities;


namespace SamRabGaynutdinov2;

public partial class RegistrationPage : ContentPage
{

    public RegistrationPage()
    {
        InitializeComponent();
    }

    private void RegistrerUser(object sender, EventArgs e)
    {
        var fio = FioEntry.Text == null ? string.Empty : FioEntry.Text.Trim();
        var login = LoginEntry.Text == null ? string.Empty : LoginEntry.Text.Trim();
        var password = PasswordEntry.Text == null ? string.Empty : PasswordEntry.Text.Trim();
        var passwordRepeat = PasswordRepeatEntry.Text == null ? string.Empty : PasswordRepeatEntry.Text.Trim();

        ApplicationDbContext dbContext = new ApplicationDbContext();

        var isFioEmpty = string.IsNullOrWhiteSpace(fio);
        if (isFioEmpty)
        {
            AppShell.Current.DisplayAlert("������", "��� ���?", "OK");
            return;
        }

        var isLoginEmpty = string.IsNullOrWhiteSpace(login);
        if (isLoginEmpty)
        {
            AppShell.Current.DisplayAlert("������", "� ����� ���?", "OK");
            return;
        }

        var isPaswordEmpty = string.IsNullOrWhiteSpace(password);
        if (isPaswordEmpty)
        {
            AppShell.Current.DisplayAlert("������", "� ������ ��� ������?", "OK");
            return;
        }

        var isLoginExist = dbContext.Users.Any(x => x.Login == login);
        if (isLoginExist)
        {
            AppShell.Current.DisplayAlert("������", "������������ ��� ���������� � ������ ������", "OK");
            return;
        }

        if (password != passwordRepeat)
        {
            AppShell.Current.DisplayAlert("������", "������ �� ���������", "OK");
            return;
        }

        dbContext.Users.Add(new UserEntity(fio ,login, password));
        dbContext.SaveChanges();
        AppShell.Current.GoToAsync("..");
    }
}