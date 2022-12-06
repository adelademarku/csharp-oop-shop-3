using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public class SacchettoDiFrutta : Prodotto
    {
        //Proprietà

        private string[] frutta;

        public SacchettoDiFrutta(string nome, double prezzo, int iva, string[] frutta) : base(nome, prezzo, iva)
        {
            this.frutta = frutta;
        }


        //Getters

        public string[] GetFrutta()
        {
            return this.frutta;

        }

        public void StampaArrayStringhe(string[] arrayDiStringhe)
        {

            Console.Write("[");

            for (int i = 0; i < arrayDiStringhe.Length; i++)
            {
                if (i == arrayDiStringhe.Length - 1)
                {
                    Console.Write("\"" + arrayDiStringhe[i] + "\"");
                }
                else
                {
                    Console.Write("\"" + arrayDiStringhe[i] + "\",");
                }
            }

            Console.WriteLine("]");
        }


        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Contiene:" 
                + StampaArrayStringhe);
            
        }




    }
}
