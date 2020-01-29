using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Student : Person
    {

        public List<Kurs> studentensKursLista = new List<Kurs>();
        public Student(string id, string förnamn, string efternamn)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            
        }
        public Student(Kurs nyKurs)
        {
            studentensKursLista.Add(nyKurs);
        }

        public List<Betyg> BetygLista { get; set; }

        public string StudentFullName()
        {
            return Förnamn + " " + Efternamn;
        }

       //Gör lista med studenter(?)
    }
}
