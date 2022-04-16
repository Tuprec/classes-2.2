using System;

namespace classes_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            resultaat leering = new resultaat();
            string strAnswer, strGraad;
            int intAantal = 0, intTotaal = 0, intPunt;
            do
            {
                Console.Write("Geef de punten in van de student(in procent): ");
                intPunt = Convert.ToInt32(Console.ReadLine());
                intTotaal += intPunt;
                intAantal++;

                Console.Write("Wilt u nog een punt ingeven?");
                strAnswer = Console.ReadLine().ToUpper();
                Console.Clear();
            } while (strAnswer == "Y");

            GemiddeldeBerekening(intAantal, intTotaal, leering);
            strGraad = resultaat.Graad(leering);
            Console.WriteLine($"De leerling behaalde {leering.Resultaat}% en heeft een {strGraad}");
        }

        private static void GemiddeldeBerekening(int intAantal, int intTotaal, resultaat leering)
        {
            int intGemiddelde;
            intGemiddelde = (intTotaal / intAantal);
            leering.Resultaat = intGemiddelde;
        }
    }
}
