using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui.Services
{
    public class PageTypePickerService : IPageTypePickerService
    {
        private readonly Dictionary<string, Type> _pageTypes;

        public PageTypePickerService()
        {
            _pageTypes = new Dictionary<string, Type>();

            var assembly = typeof(App).GetTypeInfo().Assembly;
            var types = assembly.GetTypes().Where(p => p.GetTypeInfo().IsSubclassOf(typeof(Page)));

            foreach (var type in types)
            {
                _pageTypes[type.Name] = type;
            }
        }

        public Type GetPageType(string key)
        {
            if (_pageTypes.TryGetValue(key, out var type))
            {
                return type;
            }

            throw new ArgumentException($"No page type found for key '{key}'", nameof(key));
        }

    }
}
