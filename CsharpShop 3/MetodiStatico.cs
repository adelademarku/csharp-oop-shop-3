using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public static class ConvertitoreDiLitri
    {
        public static double DaCelsiusAFahrenheit(string liquidoLitri)
        {
            double litri = double.Parse(liquidoLitri);
            double gallone = litri / 4.54609 ;
            return gallone;
        }
        public static double DaFahrenheitACelsius(string liquidoGalloni)
        {
            double gallone = double.Parse(liquidoGalloni);
            double litri = gallone * 4.54609;
            return litri;
        }
    }
}
