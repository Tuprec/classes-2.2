using System;

namespace classes_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabelen declareren
            resultaat leering = new resultaat();
            string strAnswer, strGraad;
            int intAantal = 0, intTotaal = 0, intPunt;

            //Do while lus voor alle resultaten in te geven
            do
            {
                //Opvragen van een punt
                Console.Write("Geef de punten in van de student(in procent): ");
                intPunt = Convert.ToInt32(Console.ReadLine());
                //Punt bij het totaal tellen
                intTotaal += intPunt;
                //Bijhouden hoeveel punten er zijn ingegeven voor het eindresultaat
                intAantal++;

                //Vragen of de gebruiker nog een punt wil ingeven
                Console.Write("Wilt u nog een punt ingeven?");
                strAnswer = Console.ReadLine().ToUpper();
                //De console leeg maken
                Console.Clear();
            } while (strAnswer == "Y");

            //Eindresultaat berekenen
            GemiddeldeBerekening(intAantal, intTotaal, leering);

            //Oproepen van de methode voor de graad te berekenen
            strGraad = resultaat.Graad(leering);
            //Het eindresultaat en de graad van de leerling aan de gebruiker tonen
            Console.WriteLine($"De leerling behaalde {leering.Resultaat}% en heeft een {strGraad}");
        }

        //Methode voor het eindresultaat te berekenen
        private static void GemiddeldeBerekening(int intAantal, int intTotaal, resultaat leering)
        {
            //Tussen variabel
            int intGemiddelde;

            //eindresultaat berekenen
            intGemiddelde = (intTotaal / intAantal);

            //Het eindresultaat in de variabele van de klasse steken aan de hand van de get/set functie
            leering.Resultaat = intGemiddelde;
        }
    }
}
