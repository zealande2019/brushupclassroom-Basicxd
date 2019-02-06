using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            Studerende Mikail = new Studerende("Mikail", 4, 4);

            List<Studerende> Liste = new List<Studerende>();

            Liste.Add(Mikail);

            KlasseRum klasseRum = new KlasseRum();

            klasseRum.Klasseliste = Liste;

            klasseRum.KlasseNavn = "3B";

            klasseRum.SemesterStart = new DateTime(2018,9,4);

            



            Console.WriteLine($"{Mikail}");
            Console.WriteLine($"{klasseRum.KlasseNavn}");
            Console.WriteLine($"{klasseRum.SemesterStart}");
            Console.ReadLine();
        }
    }
}
