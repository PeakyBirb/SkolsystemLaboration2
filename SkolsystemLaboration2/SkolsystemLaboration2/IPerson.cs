using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    interface IPerson
    {
		string Id { get; set; }
		string Förnamn { get; set; }
		string Efternamn { get; set; }
		string Adress { get; set; }
		string Telefonnummer { get; set; }
		string Epost { get; set; }

		
	}
}
