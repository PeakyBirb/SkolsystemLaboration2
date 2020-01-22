using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Laborationsuppgift : ILaborationsuppgift
    {
        public Kurs Kurs { get; set; }
        public List<Betyg> BetygLista { get; set; }
    }
}
