using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			Artikal a = new Artikal("001", "plazam", 25, 125);
			Console.WriteLine($"{a.sifra} - {a.naziv} - {a.uCenu} - {a.marza}% - {a.IzlCena()}");
			a.izmeniStanje(5);
			Console.WriteLine(a.stanje);
			a.izmeniStanje(7);
			Console.WriteLine(a.stanje);
			a.izmeniStanje(-20);
			Console.WriteLine(a.stanje);
			Console.ReadKey();
		}
	}

	class Artikal
	{
		public string sifra, naziv;
		//public string naziv;
		public int marza;
		public decimal uCenu;
		public int stanje = 0;
		
		public void izmeniStanje(int kom)
		{
			if (stanje + kom >= 0)
			{
				stanje += kom;
			} else
			{
				Console.WriteLine($"Stanje: {stanje} nemamo {Math.Abs(kom)}");
			}
		}


		public Artikal(string sifra, string n, int m, decimal c)
		{
			this.sifra = sifra;
			this.naziv = n;
			marza = m;
			uCenu = c;
		}

		public decimal IzlCena()
		{                   
			return uCenu * (1 + marza/ (decimal)100);
		}
	}
}
