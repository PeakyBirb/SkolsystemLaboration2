using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    interface ILaborationsuppgift
    {
        string LabID { get; set; }

        string LabNamn { get; set; }

        Kurs Kurs { get; set; }
        List<Betyg> BetygLista { get; set; }
    }
}
