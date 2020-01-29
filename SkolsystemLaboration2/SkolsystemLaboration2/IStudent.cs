using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    interface IStudent
    {
        List<Betyg> BetygLista { get; set; }
        List<Kurs> StudentensKursLista { get; set; }
    }
}
