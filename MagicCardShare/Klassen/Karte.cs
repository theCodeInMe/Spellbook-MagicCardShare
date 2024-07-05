using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{
    public enum Farbe
    { Rot = 1, Blau, Grün, Weiß, Schwarz, Farblos }

    public class Karte
    {
        public int KartenID { get; set; }
        public string Kartenname { get; set; }

        public string? Kartentext { get; set; }

        public bool Legendaer { get; set; }

        public int? Stärke { get; set; }

        public Image? Kartenbild { get; private set; }

        public int? Widerstandskraft { get; set; }
        public int? AnzahlGesamt { get; set; }
        public Dictionary<Farbe, int>? Kartenkosten { get; set; }
        public List<Faehigkeit> Faehigkeit { get; set; }

        public List<Kartenarten> Kartenarten { get; set; }

        public Karte()
        {
            Faehigkeit = new List<Faehigkeit>();
        }

        public static Karte GetEmptyCard()
        {
            return new Karte();
        }

        public override string ToString()
        {
            return $"{KartenID} {Kartenname}";
        }
    }
}