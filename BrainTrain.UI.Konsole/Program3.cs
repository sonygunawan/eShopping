using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTrain.UI.Konsole
{
    abstract class Hewan
    {
        public string Nama;

        public abstract void Berjalan();

        public abstract void Bersuara();
    }

    class Ayam : Hewan
    {
        public override void Berjalan()
        {
            Console.WriteLine("Ais ais ais..");
        }

        public override void Bersuara()
        {
            Console.WriteLine("Petok petok..");
        }

        public void Bertelur()
        {
            Console.WriteLine("Ceplok..");
        }
    }

    class Kuda : Hewan
    {
        public override void Berjalan()
        {
            Console.WriteLine("tuk tik tak tik tuk..");
        }

        public override void Bersuara()
        {
            Console.WriteLine("Hiehiehiehiehie..");
        }

        public void Jingkrak()
        {
            Console.WriteLine("gedegreekk");
        }
    }

    class Program3
    {
        static void MainMain(string[] args)
        {
            Kuda k = new Kuda();
            k.Berjalan();
            k.Jingkrak();

            Ayam a = new Ayam();
            a.Berjalan();
            a.Bertelur();

            Hewan h;
            h = k;
            h.Berjalan();
            h = a;
            h.Berjalan();

            h = a;
            h.Nama = "Blah";
            Console.WriteLine(a.Nama);
            Console.WriteLine(k.Nama);

            h = null;
            //Console.WriteLine(h.Nama); // null di-dot
            Console.WriteLine(a.Nama);
        }
    }
}
