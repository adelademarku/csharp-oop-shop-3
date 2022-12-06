using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop_3
{
    public class Prodotto  //ContenutoMultimediale

    {
        //// PROPRIETA' 

        private int codice;
        private string nome;
        private double prezzo;
        private int iva;
        /*private string descrizione;*/


        //Stato


        public Prodotto(string nome, double prezzo, int iva)
        {
            this.codice = CalcoloCodice();
            this.nome = nome;
            this.prezzo = prezzo;
            this.iva = iva;
        }
       
       /* public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }*/

        // GETTERS

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

       
        public double GetPrezzo()
        {
            return this.prezzo;
        }



//Setters



        public void IvaProdotto(int iva)
        {

            if (iva != 4 && iva != 10 && iva != 22)
            {
                this.iva = iva;

            }
            else
            {
                Console.WriteLine("Non hai inserto un l'iva");
            }
        }


        public double SetPrezzoIva()
        {
            double prezzoIVA = (this.prezzo + (this.prezzo * this.iva) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            return prezzoIVA;

        }


        public void SetPrezzo(double prezzo)
        {
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("Il prezzo non può avere un valore negativo!");
            }
        }

        private int CalcoloCodice()
        {

            Random generatoreRandom = new Random();
            int numeroCodice = generatoreRandom.Next(1000000);
            return numeroCodice;
        }





        public string GetNomeEsteso()  //Qui ho unito il bonus al compito Nome Esteso, generando di base un codice prodotto nella forma CodiceNome, con padding di 0 se necessario
        {
            string codiceStringa = this.codice.ToString();
            codiceStringa = codiceStringa.PadLeft(8, '0');
            return codiceStringa + this.nome;
        }


        //Metodi di servizio 


        public virtual void StampaProdotto()
        {
            Console.WriteLine("Codice: " + this.codice);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());

            Console.WriteLine("Prezzo: " + prezzo + "euro ");
            Console.WriteLine("Iva: " + iva + " %");
            Console.WriteLine("Prezzo con iva: " + SetPrezzoIva() + "euro ");
        }







    }
}
