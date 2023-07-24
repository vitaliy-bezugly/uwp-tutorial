using System;

namespace Tutorial.Ui.Services
{
    public interface INavigationService
    {
        void NavigateTo(Type pageType);
    }
}
