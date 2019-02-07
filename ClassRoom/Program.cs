using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();

            klasseRum.KlasseNavn = "3B";

            klasseRum.SemesterStart = new DateTime(2018,9,4);

            Console.WriteLine(klasseRum.KlasseNavn);
            
            klasseRum.KlasseListe.Add(new Studerende("Mikail", 1, 11));
            klasseRum.KlasseListe.Add(new Studerende("Subhaan", 10, 3));
            klasseRum.KlasseListe.Add(new Studerende("Dara", 20, 9));
            klasseRum.KlasseListe.Add(new Studerende("Fisnok", 28, 8));

            foreach (var mi in klasseRum.KlasseListe)
            {
                Console.WriteLine($"{mi._navn} {mi._fødselsdag} {mi._fødselsmåned} {klasseRum.Årstid(mi._fødselsmåned)}");
            }

            Console.WriteLine("-------------------");

            var vinter = klasseRum.KlasseListe
                .Count(studerende => studerende._fødselsmåned == 12 
                                     || studerende._fødselsmåned == 1 
                                     || studerende._fødselsmåned == 2);
            Console.WriteLine($"Vinter: {vinter}");

            var forår = klasseRum.KlasseListe
                .Count(studerende => studerende._fødselsmåned == 3
                                     || studerende._fødselsmåned == 4
                                     || studerende._fødselsmåned == 5);
            Console.WriteLine($"Forår: {forår}");

            var sommer = klasseRum.KlasseListe
                .Count(studerende => studerende._fødselsmåned == 6
                                     || studerende._fødselsmåned == 7
                                     || studerende._fødselsmåned == 8);
            Console.WriteLine($"Sommer: {sommer}");

            var efterår = klasseRum.KlasseListe
                .Count(studerende => studerende._fødselsmåned == 9
                                     || studerende._fødselsmåned == 10
                                     || studerende._fødselsmåned == 11);
            Console.WriteLine($"Efterår: {forår}");

            Console.ReadLine();
        }

        
    }
}
