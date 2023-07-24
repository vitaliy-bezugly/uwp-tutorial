using System;
using System.Windows.Input;
using Tutorial.Ui.Services;
using Tutorial.Ui.Utilities;
using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ICommand _navigateCommand;
        private readonly INavigationService _navigationService;
        private readonly IPageTypePickerService _pageTypePicker;

        public MainPageViewModel(Frame mainFrame)
        {
            _navigateCommand = new CommandHandler((obj) => Navigate(obj), (obj) => true);
            _navigationService = new NavigationService(mainFrame);
            _pageTypePicker = new PageTypePickerService();
        }

        public ICommand NavigateCommand => _navigateCommand;

        private void Navigate(object obj)
        {
            Type pageType = _pageTypePicker.GetPageType(obj.ToString());
            _navigationService.NavigateTo(pageType);
        }
    }
}
