using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public class BevandaMassimoException : Exception
    {
        public BevandaMassimoException() : base()
        {

        }

        public BevandaMassimoException(string message) : base(message)
        {

        }
    }
}
