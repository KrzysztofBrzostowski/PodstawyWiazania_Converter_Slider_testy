using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PodstawyWiazania
{
   class KonwerterWartosci : System.Windows.Data.IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, 
            object parameter, System.Globalization.CultureInfo culture)
        {




            double d = (double)value;
            //d = Math.Round(d, 2);
            int zm01 = (int)d;
            return zm01.ToString();

            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, 
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
