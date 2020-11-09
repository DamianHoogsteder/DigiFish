using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiFish_application
{
    class Vis
    {
        private string naam;
        private string soortVis;
        private int maxLengte;
        private bool losLatenYN;
        private bool bedrijgdeSoortYN;

        public string getNaam { get { return naam; } }
        public string getSoortVis { get { return soortVis; } }
        public decimal getMaxLengte { get { return maxLengte; } }
        public bool getLosLatenYN { get { return losLatenYN; } }
        public bool getBedrijgdeSoortYN { get { return bedrijgdeSoortYN; } }

        public Vis(string nieuweNaam, string nieuweSoortVis, int nieuweMaxLengte, bool nieuweLosLaten, bool nieuweBedrijgdeSoortYN)
        {
            naam = nieuweNaam;
            soortVis = nieuweSoortVis;
            maxLengte = nieuweMaxLengte;
            losLatenYN = nieuweLosLaten;
            bedrijgdeSoortYN = nieuweBedrijgdeSoortYN;
        }
        public string convertVisInfoSchermBool(bool visBool)
        {
            if (visBool == false)
            {
                return "Nee";
            }
            else
            {
                return "Ja";
            }
        }

    }
}
