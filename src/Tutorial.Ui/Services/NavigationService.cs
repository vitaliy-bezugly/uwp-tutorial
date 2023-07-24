using System;
using Tutorial.Ui.DIItems;

namespace Tutorial.Ui.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IFrameContainer _frameContainer;

        public NavigationService(IFrameContainer frameContainer)
        {
            _frameContainer = frameContainer;
        }

        public void NavigateTo(Type pageType)
        {
            _frameContainer.MainFrame.Navigate(pageType);
        }
    }
}
