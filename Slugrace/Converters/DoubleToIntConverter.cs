﻿using System.Globalization;

namespace Slugrace.Converters;

public class DoubleToIntConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (!double.TryParse(parameter as string, out double granularity))
        {
            granularity = 1;
        }

        return (int)((double)value! / granularity);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (!double.TryParse(parameter as string, out double granularity))
        {
            granularity = 1;
        }

        return (double)((int)value! * granularity);
    }
}

