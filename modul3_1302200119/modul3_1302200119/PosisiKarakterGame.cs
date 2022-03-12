using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200119
{
    internal class PosisiKarakterGame
    {
        public enum Posisi
        {
            Jongkok, Berdiri, Tengkurap, Terbang
        }
        public enum Tombol
        {
            TombolW, TombolS, TombolX
        }
        public Posisi posisiSekarang;

        public PosisiKarakterGame(Posisi sekarang)
        {
            this.posisiSekarang = sekarang;
        }

        public class Transisi
        {
            public Posisi posisiAwal, posisiAkhir;
            public Tombol tombol;

            public Transisi(Posisi posisiAwal, Posisi posisiAkhir, Tombol tombol)
            {
                this.posisiAwal = posisiAwal;
                this.posisiAkhir = posisiAkhir;
                this.tombol = tombol;
            }
        }

        Transisi[] transisi = 
            {
                new Transisi(Posisi.Jongkok, Posisi.Berdiri, Tombol.TombolW),
                new Transisi(Posisi.Jongkok, Posisi.Tengkurap, Tombol.TombolS),
                new Transisi(Posisi.Berdiri, Posisi.Jongkok, Tombol.TombolS),
                new Transisi(Posisi.Berdiri, Posisi.Terbang, Tombol.TombolW),
                new Transisi(Posisi.Terbang, Posisi.Berdiri, Tombol.TombolS),
                new Transisi(Posisi.Terbang, Posisi.Jongkok, Tombol.TombolX),
                new Transisi(Posisi.Tengkurap, Posisi.Jongkok, Tombol.TombolW)
            };

        public Posisi getPosisiSelanjutnya(Posisi awal, Tombol tombol)
        {
            Posisi posisiSelanjutnya = awal;

            for(int i = 0; i < transisi.Length; i++)
            {
                if(transisi[i].posisiAwal == awal && transisi[i].tombol == tombol)
                {
                    posisiSelanjutnya = transisi[i].posisiAkhir;
                }
            }

            return posisiSelanjutnya;
        }

        public void pencetTombol(Tombol tombol)
        {
            Posisi posisiSelanjutnya = getPosisiSelanjutnya(posisiSekarang, tombol);

            Console.WriteLine("\nmenekan "+tombol);
            Console.WriteLine("Posisi saat ini : "+posisiSelanjutnya);

            this.posisiSekarang = posisiSelanjutnya;

            if(this.posisiSekarang == Posisi.Berdiri)
            {
                Console.WriteLine("posisi standby");
            }
            else if(this.posisiSekarang == Posisi.Tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }
        }

    }
}
