using SamRabGaynutdinov2.DatabaseContent;

namespace SamRabGaynutdinov2;

public partial class ViewTrainingPage : ContentPage
{
	public ViewTrainingPage()
	{
		InitializeComponent();
	}

    private void RefreshData(object sender, EventArgs e)
    {
        RefreshCollectionView();
        RefreshV.IsRefreshing = false;
    }

    private void RefreshCollectionView()
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        TrainingCL.ItemsSource = dbContext.Trainings.ToList();
    }
}