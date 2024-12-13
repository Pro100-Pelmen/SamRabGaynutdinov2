using SamRabGaynutdinov2.DatabaseContent;

namespace SamRabGaynutdinov2
{
    public partial class MenuPage : ContentPage
    {

        public MenuPage()
        {
            InitializeComponent();
        }

        private void RefreshData(object sender, EventArgs e)
        {
            RefreshCollectionView();
            RefreshV.IsRefreshing = false;
        }

        private void GoToAddTrainingPage(object sender, EventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(AddTrainingPage), true);
        }

        private void RefreshCollectionView()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            TrainingCL.ItemsSource = dbContext.Trainings.ToList();
        }
    }

}
