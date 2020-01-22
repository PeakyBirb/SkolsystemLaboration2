using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    class Betyg : IBetyg
    {
        private string tilldelatBetyg;
        public string TilldelatBetyg { get; set; }

        public Kurs Kurs { get; set; } 
        public Laborationsuppgift Laborationsuppgift { get; set; }


    }
}
