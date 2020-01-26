using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Laborationsuppgift : ILaborationsuppgift
    {
        private string labID;

        public string LabID
        {
            get { return labID; }
            set { labID = value; }
        }

        private string labNamn;

        public string LabNamn
        {
            get { return labNamn; }
            set { labNamn = value; }
        }


        public Kurs Kurs { get; set; }
        public List<Betyg> BetygLista { get; set; }
    }
}
