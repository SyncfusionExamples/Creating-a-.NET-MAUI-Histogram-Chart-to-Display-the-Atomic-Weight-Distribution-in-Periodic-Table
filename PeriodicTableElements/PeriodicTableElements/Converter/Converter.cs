using System.Globalization;


namespace PeriodicTableElements
{
    public class TooltipValueConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is List<object> data)
            {
                return  data.Count.ToString();
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class TooltipLabelConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var interval = 12;
            if (value is List<object> list)
            {
                var data = list[0] as Model;
                int index = (int)data!.AtomicWeight / interval;
                int x = index * interval;
                string text = x.ToString() + " - " + (x + interval).ToString();
                return text;
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
