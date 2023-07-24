using Microsoft.Extensions.DependencyInjection;
using Tutorial.Ui.DIItems;
using Tutorial.Ui.Pages;
using Tutorial.Ui.Services;
using Tutorial.Ui.ViewModels;

namespace Tutorial.Ui
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IPageTypePickerService, PageTypePickerService>();

            services.AddSingleton<DataService>();

            services.AddSingleton<IFrameContainer, FrameContainer>();

            services.AddTransient<MainPage>();
            services.AddTransient<MainPageViewModel>();

            services.AddTransient<ListViewPage>();
            services.AddTransient<ListViewPageViewModel>();

            services.AddTransient<SettingsPage>();

            return services;
        }
    }
}
