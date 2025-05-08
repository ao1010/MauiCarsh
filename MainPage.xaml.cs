using MauiCrash.ViewModels;

namespace MauiCrash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (PassengerCollectionView.SelectedItem != null)
            {
                PassengerCollectionView.ScrollTo(PassengerCollectionView.SelectedItem, null, ScrollToPosition.MakeVisible, true);
            }
        }
    }
}
