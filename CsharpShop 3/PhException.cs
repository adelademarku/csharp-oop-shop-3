using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public class PhNonEsiste : Exception
    {
        public PhNonEsiste() : base()
        {

        }

        public PhNonEsiste(string message) : base(message)
        {

        }
    }
}
