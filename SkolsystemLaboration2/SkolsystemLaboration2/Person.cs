using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public abstract class Person : IPerson
    {
		private string förnamn;
		public string Förnamn { get; set; }


		private string efternamn;
		public string Efternamn { get; set; }

		private string id;
		public string Id { get; set; }



	}
}
