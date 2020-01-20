using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    class Student : Person
    {
        public Student(string id, string förnamn, string efternamn, string adress, string telefonnummer, string epost)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Adress = adress;
            Telefonnummer = telefonnummer;
            Epost = epost;
        }
       //Gör lista med studenter
    }
}
