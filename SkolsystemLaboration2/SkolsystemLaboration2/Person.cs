using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    abstract class Person : IPerson
    {
		private string id;
		public string Id { get; set; }


		private string förnamn;
		public string Förnamn { get; set; }


		private string efternamn;
		public string Efternamn { get; set; }


		private string adress;
		public string Adress { get; set; }


		private string telefonnummer;
		public string Telefonnummer { get; set; }


		private string epost;
		public string Epost { get; set; }



		public void SkapaAnvändare(string Id, string Förnamn, string Efternamn, string Adress, string telefon)
		{

		}

	}
}
