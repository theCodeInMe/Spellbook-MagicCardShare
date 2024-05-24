using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{

    public enum Farbe
    { Rot, Blau, Grün, Schwarz, Weiß, Farblos }
     public class Karte
    {
        
      
        public int KartenID { get; private set; }
        public string Kartenname { get; private set; }

        public string? Kartentext { get; private set; }

        public bool Legendaer { get; private set; }
        public Dictionary<Farbe,int> Kartenkosten {  get; private set; } 

        public Faehigkeit Faehigkeit { get; private set; }
        public int? Stärke { get; private set; }
        public Image Kartenbild {  get; private set; }

        public int? Widerstandskraft { get; private set; }
        public int AnzahlGesamt { get; private set; }

        public static Karte GetEmptyCard()
        {
            return new Karte();
        }

        public int GetAnzahlGesamt()
        { 
            return this.AnzahlGesamt;
        }
    }
}