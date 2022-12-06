using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public class Bevanda : Prodotto
    {

        private double ph;
        private string sorgente;
        private int capacitaMassimalitri;
        private int contenutolitri;
        private bool naturale;
        public Bevanda(string nome, string sorgente, double ph, int capacitaMassimalitri, bool naturale, double prezzo, int iva) : base(nome, prezzo, iva)
        {
           if (ph <0 && ph>14) {
                throw new PhNonEsiste("Ph inserito è al di fuore della scala consentita");
            }

            this.sorgente = sorgente;
            this.ph = ph;
            this.capacitaMassimalitri = capacitaMassimalitri;
            this.naturale = naturale;

        }


        //getters


        public double GetPh()
        {
            return ph;
        }

        public string GetProvenienzaSorgente()
        {
            return sorgente;
        }

        public int GetCapacitaMassimalitri()
        {
            return capacitaMassimalitri;
        }
        public int GetContenutoLitri()
        {
            return contenutolitri;
        }

        public bool GetTipo()
        {
            return this.naturale;
        }




        //Metodi

        public void SetPh()
        {
            if (ph < 0 && ph >14)
            {
                throw new PhNonEsiste("Ph inserito è al di fuore della scala consentita");
            }
        }



        public void SetTipo()
        {
            if (naturale == true)
            {
                Console.WriteLine("Naturale");
            }
            else { Console.WriteLine("Frizzante"); }
        }


        public int ContenitoreDelAcqua()
        {
            this.contenutolitri = capacitaMassimalitri;
            return contenutolitri;
        }
        //riempi 

        public int RiempiContenitoreDelAcqua(int litri)
        {
            if (contenutolitri + litri > capacitaMassimalitri)
            {
                /*contenutolitri = capacitaMassimalitri;*/
                throw new BevandaMassimoException("attenzione la bottiglia è gia piena!");
            }
            else
            {
                this.contenutolitri = this.contenutolitri + litri;
            }

            return contenutolitri;
        }

        //bevi

        public int SvuotaMentreBevi(int litri)
        {
            if (contenutolitri - litri > 0)
            {
                /*contenutolitri = 0;*/
                throw new ArgumentException("attenzione la bottiglia è gia vuota non puoi piu bere!");
            }
            else
            {
                this.contenutolitri = this.contenutolitri - litri;
            }
            return contenutolitri;
        }

        //svuota tutto

        public int SvuotaTuttalAcqua(int litri)
        {
            this.contenutolitri = contenutolitri - litri;
            return contenutolitri;
        }

        //Metodo pubblico

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Ph. :" + ph);
            Console.WriteLine("Sorgente" + sorgente);
            Console.WriteLine("Litri attuali :" + contenutolitri);
            Console.WriteLine("Litri  :" + capacitaMassimalitri);
            Console.WriteLine(GetTipo());
        }



    }
}
