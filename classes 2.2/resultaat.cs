using System;
using System.Collections.Generic;
using System.Text;

namespace classes_2._2
{
    class resultaat
    {
        private int intresultaat;

        public int Resultaat
        {
            get { return intresultaat; }
            set { intresultaat = value; }
        }
        
        public static string Graad(resultaat leerling)
        {
            if (leerling.Resultaat < 50)
            {
                return "Niet Geslaagd!";
            }
            else if (leerling.Resultaat < 68)
            {
                return "Voldoende!";
            }
            else if (leerling.Resultaat < 75)
            {
                return "Onderscheiding";
            }
            else if (leerling.Resultaat < 85)
            {
                return "Grote Onderscheiding ";
            }
            else
            {
                return "Grootste onderscheiding";
            }
        }
    }
}
