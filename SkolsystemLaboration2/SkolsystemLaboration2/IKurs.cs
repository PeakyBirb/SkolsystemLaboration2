using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    interface IKurs
    {
        string KursID { get; set; }

        string KursNamn { get; set; }

        List<Student> StudenterPåKurs { get; set; }

        List<Lärare> LärarePåKurs { get; set; }

        List<Kurs> KursLista { get; set; }
        List<Betyg> BetygLista { get; set; }
        List<Laborationsuppgift> LaborationsuppgiftLista { get; set; }



	}
}
