using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Student : Person, IStudent
    {

        public List<Kurs> StudentensKursLista { get; set; }
        public Student(string id, string förnamn, string efternamn)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            
        }
        public Student(Kurs nyKurs)
        {
            StudentensKursLista.Add(nyKurs);
        }

        public List<Betyg> BetygLista { get; set; }

        
    }
}
