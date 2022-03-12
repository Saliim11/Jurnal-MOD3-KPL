using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Table-Driven
            KodeBuah buah1 = new KodeBuah();
            Console.WriteLine(buah1.getKodeBuah(KodeBuah.Buah.Semangka));

            
        }
    }
}
