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
            set { KursID = value; }
        }


        private string kursNamn;

        public string KursNamn
        {
            get { return kursNamn; }
            set { KursNamn = value; }
        }

        
        
       

        public List<Student> StudenterPåKurs { get; set; }

        public List<Lärare> LärarePåKurs { get; set; }
        public List<Kurs> KursLista { get; set; }
        public List<Betyg> BetygLista { get; set; }
        public List<Laborationsuppgift> LaborationsuppgiftLista { get; set; }


        public Kurs(string KursID, string KursNamn, List<Student> StudenterPåKurs, List<Lärare> LärarePåKurs)
        {

        }

    }
}
