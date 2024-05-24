using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{
    public class Benutzer: TableSQL
    {
        
        public string Benutzername { get; private set; }
        public string Passwort { get; private set; }

        public Benutzer(int id,string benutzername, string passwort):base(id)
        {
            Benutzername = benutzername;
            Passwort = passwort;
        }
    }
}
