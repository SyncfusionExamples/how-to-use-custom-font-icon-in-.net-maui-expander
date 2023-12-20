using System.Globalization;

namespace ExpanderMaui
{
 public class ExpanderIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return "\ue700";              
            }
            else
            {             
                return "\ue701";               
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
