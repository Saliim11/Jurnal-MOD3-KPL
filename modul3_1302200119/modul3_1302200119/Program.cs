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

            //State-Based
            PosisiKarakterGame P1 = new PosisiKarakterGame(PosisiKarakterGame.Posisi.Jongkok);
            Console.WriteLine("Posisi Sekarang : " + P1.posisiSekarang);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolS);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolW);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolW);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolW);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolX);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolW);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolW);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolS);
            P1.pencetTombol(PosisiKarakterGame.Tombol.TombolS);

        }
    }
}
