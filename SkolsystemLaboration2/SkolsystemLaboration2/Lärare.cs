using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Lärare : Person, ILärare
    {
        private int lön;
        public int Lön
        {
            get { return lön; }
            set { lön = value; }
        }

        public Lärare(string id, string förnamn, string efternamn, int lön)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Lön = lön;
        }
        
    }
}
