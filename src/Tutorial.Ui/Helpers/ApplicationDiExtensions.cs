using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml;

namespace Tutorial.Ui.Helpers
{
    public static class ApplicationDiExtensions
    {
        public static T GetService<T>(this Application application)
        {
            return ((App)application).ServiceProvider.GetService<T>();
        }
    }
}
