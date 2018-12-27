﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Hurricane.GUI.Converter
{
    class StringArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString())) return string.Empty;

            return string.Join(", ", (string[])value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString())) return null;
            return value.ToString().Split(new string[] { ",", ", " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
