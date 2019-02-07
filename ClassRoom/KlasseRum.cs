using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace ClassRoom
{
    public class KlasseRum
    {
        public List<Studerende> KlasseListe { get; set; } = new List<Studerende>();
        public string KlasseNavn { get; set; }
        public DateTime SemesterStart { get; set; }


        public KlasseRum()
        {
        }

        public string Årstid(int fødselsmåned)
        {
            if (fødselsmåned == 12 || fødselsmåned == 1 ||   fødselsmåned == 2)
            {
                string tid = "Vinter";
                return tid;
            }
            else if (fødselsmåned == 3 || fødselsmåned == 4 || fødselsmåned == 5)
            {
                string tid = "Forår";
                return tid;
            }
            else if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                string tid = "Sommer";
                return tid;
            }
            else if (fødselsmåned == 9 || fødselsmåned == 10 || fødselsmåned == 11)
            {
                string tid = "Efterår";
                return tid;
            }
            return "WRONG";
        }
    }
}