using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
        }

        public void Print()
        {
            Console.WriteLine($"{KlasseNavn} {Klasseliste} {SemesterStart}");

            
        }
    }
}