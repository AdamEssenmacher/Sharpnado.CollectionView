﻿using System.Globalization;
using MauiSample.Presentation.ViewModels;

namespace MauiSample.Presentation.Converters
{
    public class ListModeToInt: IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (ListMode)value;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
