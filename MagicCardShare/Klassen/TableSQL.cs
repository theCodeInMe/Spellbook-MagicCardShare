using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCardShare.Klassen
{
    public abstract class TableSQL
    {
        public int ID { get; set; }

        public TableSQL(int id) 
        {  
            ID = id;
        }

    }
}
