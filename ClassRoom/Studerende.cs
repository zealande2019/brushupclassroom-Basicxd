namespace ClassRoom
{
    public class Studerende
    {
        public string _navn;
        public int _fødselsmåned;
        public int _fødselsdag;
      

        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            _navn = navn;
            _fødselsdag = fødselsdag;
            _fødselsmåned = fødselsmåned;
            
        }

    }
}