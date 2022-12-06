// See https://aka.ms/new-console-template for more information
//vi chiedo di inserire correttamente le Eccezioni nei vostri Prodotti e sotto prodotti in modo da gestire correttamente gli eventi eccezionali,
//senza dover più fare un semplice Console.WriteLIne().
//Come primo esercizio focalizzatevi bene SOLO sulla classe Prodotto e sottoclasse Acqua dove potete aggiungere le seguenti Eccezioni:
//nel costruttore di Acqua, non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10. 
//O ancora non posso avere una capienza sopra la capienza massima o negativa e così via.
//nel metodo bevi (double litriDaBere) se l’acqua finisce, restituire un eccezione magari costruita da voi.
//metodo riempi(double litri) che riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza massima.
//un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni,
//sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).

using CsharpShop_3;

Console.WriteLine("Hello, World!");

try
{
    Bevanda Levissima = new Bevanda("Levissima", "Bormio", -6, 1500, true, 0.88, 22);
}
catch (PhNonEsiste e)
{
    Console.WriteLine(e.Message);

}
 

string[] frutta = { "mela", "pera", "banana" };

SacchettoDiFrutta misto = new SacchettoDiFrutta("Misto", 3.5, 4, frutta);
misto.StampaProdotto();

Elettrodomestico lavatrice = new Elettrodomestico("Lavatrice", 300, 22);

lavatrice.StampaProdotto();

CiboInScattola tonno = new CiboInScattola("Tonno", 1.55, 10);

tonno.StampaProdotto();