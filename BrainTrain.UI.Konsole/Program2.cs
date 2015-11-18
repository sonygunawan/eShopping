using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTrain.UI.Konsole
{
    struct Karyawan
    {
        public string Nama;
        public int Usia;

        public void Halo()
        {
            Console.WriteLine("Halo {0} ({1})", Nama, Usia);
        }
    }

    class Persegi
    {
        private int panjang;
        private int tinggi;

        public int Panjang
        {
            get { return panjang; }
            set 
            { 
                if (value >= 0)
                    panjang = value; 
            }
        }

        public int Tinggi
        {
            get { return tinggi; }
            set
            {
                if (value >= 0)
                    tinggi = value;
            }
        }

        public int Luas
        {
            get { return panjang * tinggi; }
        }

        public void Tampilkan()
        {
            for (int t = 0; t < tinggi; ++t)
            {
                for (int p = 0; p < panjang; ++p)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            Persegi p1 = new Persegi();
            p1.Panjang = 3;
            p1.Tinggi = 4;

            Persegi p2 = p1;
            Console.WriteLine(p2.Panjang);
            p1.Panjang = 6;
            Console.WriteLine(p2.Panjang);

            //Persegi p = new Persegi();
            ////p.panjang = 4;
            ////p.SetPanjang(-4);
            //p.Panjang = 4;
            //p.Tinggi = 3;
            ////p.Luas = 0;
            //Console.WriteLine(p.Luas);
            //p.Tampilkan();

            //Console.WriteLine(p.Panjang);
        }

        static void MainKaryawan(string[] args)
        {
            Karyawan k;
            Console.WriteLine("Nama: ");
            k.Nama = Console.ReadLine();
            Console.WriteLine("Usia: ");
            k.Usia = int.Parse(Console.ReadLine());

            Karyawan k2;
            Console.WriteLine("Nama: ");
            k2.Nama = Console.ReadLine();
            Console.WriteLine("Usia: ");
            k2.Usia = int.Parse(Console.ReadLine());

            k.Halo();
            k2.Halo();
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Nama: ");
            string nama = Console.ReadLine();
            Console.WriteLine("Usia: ");
            int usia = int.Parse(Console.ReadLine());

            Console.WriteLine("Nama: ");
            string nama2 = Console.ReadLine();
            Console.WriteLine("Usia: ");
            int usia2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Halo {0} ({1})", nama, usia);
            Console.WriteLine("Halo {0} ({1})", nama2, usia2);
        }
    }
}
