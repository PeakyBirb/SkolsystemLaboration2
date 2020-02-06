using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Kurs : IKurs
    {
        private string kursID;
        public string KursID
        {
            get { return kursID; }
            set { kursID = value; }
        }


        private string kursNamn;

        public string KursNamn
        {
            get { return kursNamn; }
            set { kursNamn = value; }
        }



        public List<Student> StudenterPåKurs { get; set; }

        public List<Lärare> LärarePåKurs { get; set; }
        public List<Betyg> BetygLista { get; set; }
        public List<Laborationsuppgift> LaborationsuppgifterPåKurs { get; set; }



        public Kurs(string kursID, string kursNamn, List<Student> studenterPåKurs, List<Lärare> lärarePåKurs)
        {
            KursID = kursID;
            KursNamn = kursNamn;
            StudenterPåKurs = studenterPåKurs;
            LärarePåKurs = lärarePåKurs;

        }

        public Kurs(List<Laborationsuppgift> laborationsuppgifterPåKurs)
        {
            LaborationsuppgifterPåKurs = laborationsuppgifterPåKurs;
        }
        public Kurs(List<Betyg> betyglista)
        {
            BetygLista = betyglista;
        }


        public Kurs(List<Student> studenterPåKurs)
        {
            StudenterPåKurs = studenterPåKurs;

        }

        public Kurs(List<Lärare> lärarePåKurs)
        {
            LärarePåKurs = lärarePåKurs;

        }

        public List<Student> DeltagandeStudenterPåKurs()
        {
            return StudenterPåKurs;
        }



    }
}
