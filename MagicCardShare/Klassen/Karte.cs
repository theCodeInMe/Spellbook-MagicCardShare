using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{
    internal class Karte
    {
      
        public int KartenID { get; private set; }
        public string Kartenname { get; private set; }

        public string? Kartentext { get; private set; }

        public bool Legendär { get; private set; }

        public int? Stärke { get; private set; }

        public int? Widerstandskraft { get; private set; }

        public static Karte GetEmptyCard()
        {
            return new Karte();
        }

        public static void AnzahlGesamt()
        {
        }
    }
}