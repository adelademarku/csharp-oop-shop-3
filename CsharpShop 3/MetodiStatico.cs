using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public static class ConvertitoreDiLitri
    {
        public static double DalitriAGallone(double liquidoLitri)
        {
            double litri = liquidoLitri;
            double gallone = litri * 4.54609 ;
            return gallone;
        }
        public static double DaGalloneALitro(double liquidoGalloni)
        {
            double gallone = liquidoGalloni;
            double litri = gallone / 4.54609;
            return litri;
        }
    }
}
