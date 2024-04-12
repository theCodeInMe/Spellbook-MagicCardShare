using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{
    internal class KarteBenutzer
    {
        public int KartenID { get; private set; }
        public int SpielerID { get; private set; }
        public int AnzahlSpielerKarten { get; private set; }
        public bool Tauschbar { get; private set; }

    }

}
