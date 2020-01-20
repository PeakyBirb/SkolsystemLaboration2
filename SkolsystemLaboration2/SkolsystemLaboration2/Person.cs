using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    class Person : IPerson
    {
        private string id;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}
		
		private string förnamn;

		public string Förnamn
		{
			get { return förnamn; }
			set { förnamn = value; }
		}
		
		private string efternamn;

		public string Efternamn
		{
			get { return efternamn; }
			set { efternamn = value; }
		}

		private string adress;

		public string Adress
		{
			get { return adress; }
			set { adress = value; }
		}

		private string telefonnummer;

		public string Telefonnummer
		{
			get { return telefonnummer; }
			set { telefonnummer = value; }
		}

		private string epost;

		public string Epost
		{
			get { return epost; }
			set { epost = value; }
		}

		

		public void SkapaAnvändare(string Id, string Förnamn, string Efternamn, string Adress, string telefon) 
		{ 
			
		}

	}
}
