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

        List<Student> StudenterPåKurs { get; set; }

        List<Lärare> LärarePåKurs { get; set; }

        List<Kurs> KursLista { get; set; }

	}
}
