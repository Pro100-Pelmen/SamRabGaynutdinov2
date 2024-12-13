using SamRabGaynutdinov2.DatabaseContent;
using SamRabGaynutdinov2.Entities;

namespace SamRabGaynutdinov2;

public partial class AddTrainingPage : ContentPage
{
	public AddTrainingPage()
	{
		InitializeComponent();
	}

    private void addTraining(object sender, EventArgs e)
    {
        AppShell.Current.DisplayAlert("", FileSystem.Current.AppDataDirectory, "asd");
        string title = TitleEntry.Text;
        string description = DescriptionEntry.Text;
        string amount = AmountEntry.Text;

        bool isTitleEmpty = string.IsNullOrWhiteSpace(title);
        if (isTitleEmpty)
        {
            AppShell.Current.DisplayAlert("�����", "�������� ���������� �� ����� ���� ������!", "��");
            return;
        }

        bool isDescriptionEmpty = string.IsNullOrWhiteSpace(description);
        if (isDescriptionEmpty)
        {
            AppShell.Current.DisplayAlert("�����", "�������� ���������� �� ����� ���� ������!", "��");
            return;
        }

        bool isAmountEmpty = string.IsNullOrWhiteSpace(amount);
        if (isAmountEmpty)
        {
            AppShell.Current.DisplayAlert("�����", "���������� �������� �� ����� ���� ������!", "��");
            return;
        }

        decimal amountConvertedToDecimal = Convert.ToDecimal(amount);

        ApplicationDbContext dbContext = new ApplicationDbContext();
        dbContext.Trainings.Add(new TrainingEntity(title, description, amountConvertedToDecimal));
        dbContext.SaveChanges();

        AppShell.Current.DisplayAlert("�����", "������ � ���������� ������� ���������!", "��");
        AppShell.Current.GoToAsync("..", true);
    }
}