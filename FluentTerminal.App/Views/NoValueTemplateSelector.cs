﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FluentTerminal.App.Views
{
    public class NoValueTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate CustomTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is string arguments)
            {
                return string.IsNullOrEmpty(arguments) ? DefaultTemplate : CustomTemplate;
            }
            return null;
        }
    }
}
