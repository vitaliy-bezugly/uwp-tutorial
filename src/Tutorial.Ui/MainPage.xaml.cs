using Tutorial.Ui.Pages;
using Tutorial.Ui.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new MainPageViewModel(MainFrame);

            MainFrame.Navigate(typeof(ListViewPage));
        }
    }
}
