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
            AppShell.Current.DisplayAlert("Ошбка", "Название упражнения не может быть пустым!", "Ок");
            return;
        }

        bool isDescriptionEmpty = string.IsNullOrWhiteSpace(description);
        if (isDescriptionEmpty)
        {
            AppShell.Current.DisplayAlert("Ошбка", "Описание упражнения не может быть пустым!", "Ок");
            return;
        }

        bool isAmountEmpty = string.IsNullOrWhiteSpace(amount);
        if (isAmountEmpty)
        {
            AppShell.Current.DisplayAlert("Ошбка", "Количество подходов не может быть пустым!", "Ок");
            return;
        }

        decimal amountConvertedToDecimal = Convert.ToDecimal(amount);

        ApplicationDbContext dbContext = new ApplicationDbContext();
        dbContext.Trainings.Add(new TrainingEntity(title, description, amountConvertedToDecimal));
        dbContext.SaveChanges();

        AppShell.Current.DisplayAlert("Успех", "Запись о тренировке успешно добавлена!", "Ок");
        AppShell.Current.GoToAsync("..", true);
    }
}