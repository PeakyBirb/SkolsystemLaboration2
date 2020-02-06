using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    interface IBetyg
    {
        string TilldelatBetyg { get; set; }
        
        Kurs Kurs { get; set; }

        Laborationsuppgift Laborationsuppgift { get; set; }
        Student Student { get; set; }

        


    }
}
