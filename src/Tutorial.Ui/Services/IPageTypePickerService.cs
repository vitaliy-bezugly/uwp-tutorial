using System;

namespace Tutorial.Ui.Services
{
    public interface IPageTypePickerService
    {
        Type GetPageType(string key);
    }
}
