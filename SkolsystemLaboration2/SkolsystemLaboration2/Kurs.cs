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
        public string KursID { get; set; }


        private string kursNamn;
        public string KursNamn { get; set; }
        
        
       

        public List<Student> StudenterPåKurs { get; set; }

        public List<Lärare> LärarePåKurs { get; set; }
        public List<Kurs> KursLista { get; set; }
        public List<Betyg> BetygLista { get; set; }
        public List<Laborationsuppgift> LaborationsuppgiftLista { get; set; }

    }
}
