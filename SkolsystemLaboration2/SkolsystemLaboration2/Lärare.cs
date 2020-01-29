using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Lärare : Person, ILärare
    {
        public Lärare(string id, string förnamn, string efternamn)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            

        }
        //Gör lista med lärare
    }
}
