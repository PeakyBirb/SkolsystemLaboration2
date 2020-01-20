using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    class Kurs : IKurs
    {
        private string kursID;

        public string KursID
        {
            get { return kursID; }
            set { kursID = value; }
        }


        public List<Student> StudenterPåKurs { get; set; }

        public List<Lärare> LärarePåKurs { get; set; }
        
        public List<Kurs> KursLista { get; set; }
    }
}
