using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PodstawyWiazania
{
    class Konwerter_wartosci_toString : System.Windows.Data.IValueConverter
    {
        #region IValueConverter Members

        public String liczba;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            
            //liczba = new String('*', 20);
            double double_ = (double)value;
            //d = Math.Round(d, 2);
            int zm01 = (int)double_;


            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(5, "piec");
            d.Add(6, "szesc");
            d.Add(7, "siedem");
            d.Add(8, "osiem");
            d.Add(9, "dziewiec");
        //    d.Add(10,"dziesiec");


            if (d.ContainsKey(zm01))
            {
                return d[zm01];
            }
            else
                return "liczba " + zm01.ToString();


/*

            if (zm01 == 5) { liczba = "piec"; return liczba; }
            else
                if (zm01 == 6) { liczba = "szesc"; return liczba; }
                else
                    if (zm01 == 7) { liczba = "siedem"; return liczba; }
                    else
                        if (zm01 == 8) { liczba = "osiem"; return liczba; }
                        else
                            if (zm01 == 9) { liczba = "dziewiec"; return liczba; }
                            else
                                if (zm01 == 10) { liczba = "dziesiec"; return liczba; }
                                else return "zero";



            return zm01.ToString();


*/

            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
