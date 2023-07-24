using Microsoft.Extensions.DependencyInjection;
using Tutorial.Ui.DIItems;
using Tutorial.Ui.Helpers;
using Tutorial.Ui.Pages;
using Tutorial.Ui.Services;
using Tutorial.Ui.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeDiItems();

            var navigationService = Application.Current.GetService<INavigationService>();
            navigationService.NavigateTo(typeof(ListViewPage));

            DataContext = Application.Current.GetService<MainPageViewModel>();
        }

        private void InitializeDiItems()
        {
            var frameContainer = Application.Current.GetService<IFrameContainer>();
            frameContainer.InstallFrame(MainFrame);
        }
    }
}
