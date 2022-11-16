using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeVjezba03
{

    class Biljka
    {

    }
    class Stablo : Biljka
    {
        public bool opadajuListovi;

        public Stablo()
        {
        }

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
    class Cvijet : Biljka
    {

    }
    class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno hrast = new Bijelogoricno(true);
            Crnogoricno bor = new Crnogoricno(false);
            Console.WriteLine("Hrast opadaju listovi: " + hrast.opadajuListovi);
            Console.WriteLine("Bor opadaju listovi: " + bor.opadajuListovi);
            Console.ReadKey();
        }
    }
}
