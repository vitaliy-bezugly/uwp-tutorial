using System;
using System.Windows.Input;
using Tutorial.Ui.Services;
using Tutorial.Ui.Utilities;

namespace Tutorial.Ui.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ICommand _navigateCommand;
        private readonly INavigationService _navigationService;
        private readonly IPageTypePickerService _pageTypePicker;

        public MainPageViewModel(INavigationService navigationService, IPageTypePickerService pageTypePicker)
        {
            _navigationService = navigationService;
            _pageTypePicker = pageTypePicker;

            _navigateCommand = new CommandHandler((obj) => Navigate(obj), (obj) => true);
        }

        public ICommand NavigateCommand => _navigateCommand;

        private void Navigate(object obj)
        {
            Type pageType = _pageTypePicker.GetPageType(obj.ToString());
            _navigationService.NavigateTo(pageType);
        }
    }
}
