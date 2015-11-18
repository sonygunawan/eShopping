using System;

public class Program
{
    static void Baz()
    {
        Baz();
    }

    static void Foo()
    {
        Console.WriteLine("foo start");
        Bar();
        Console.WriteLine("foo end");
    }

    private static void Bar()
    {
        Console.WriteLine("bar start");
        Console.WriteLine("bar end");
    }

    static void MainStack(string[] args)
    {
        Baz();

        Foo();
        Bar();
    }

    
    /// ///////////////////////////////////////////////////////////
    


    static void Makan(string makanan)
    {        
        Console.WriteLine("Cuci tangan");
        Console.WriteLine("Makan " + makanan);
        Console.WriteLine("Cuci piring");
    }

    static void TampilkanPersegi(int panjang, int tinggi)
    {
        int t = 0;
        while (t < tinggi)
        {
            int p = 0;
            while (p < panjang)
            {
                Console.Write("* ");
                p++;
            }
            Console.WriteLine();
            t++;
        }
    }

    static void TampilkanKuadrat(int angka)
    {
        Console.WriteLine(angka * angka );
    }

    static int Kuadrat(int angka)
    {
        return angka * angka;
    }

    // pengulangan kita harus paranoid
    static void MainMain(string[] args)
    {
        //Makan("Bakso");
        /////
        /////
        /////

        //Makan("Ayam");
        /////
        /////
        /////
        //Makan("Jus");

        TampilkanKuadrat(5); // 25
        Console.WriteLine(Kuadrat(5) + 1);

        Console.Write("Panjang: ");
        int panjang = int.Parse(Console.ReadLine());
        Console.Write("Tinggi: ");
        int tinggi = int.Parse(Console.ReadLine());

        TampilkanPersegi(panjang, tinggi);
        int luas = LuasPersegi(panjang, tinggi);
        Console.WriteLine(luas);

        int max = Terbesar(3, 20);
        Console.WriteLine(max);

        // 5^2 + 1
    }

    private static int Terbesar(int a, int b)
    {
        if (a > b)
            return a;
        return b;
    }

    private static int LuasPersegi(int panjang, int tinggi)
    {
        return panjang * tinggi;
    }

    static void TicTacToe(string[] args)
    {
        char[] board = new char[] { '.', '.', '.', 
                                    '.', '.', '.', 
                                    '.', '.', '.', };

        char side = 'X';
        while (true)
        {
            for (int i = 0; i < 9; ++i)
                Console.Write(" {0} {1}", board[i], (i + 1) % 3 == 0? "\n" : " ");
            Console.Write("\n{0}: ", side);
            int cell = int.Parse(Console.ReadLine());
            board[cell - 1] = side;
            side = (side == 'X') ? 'O' : 'X';
        }
    }

    static void WhileFor(string[] args)
    {
        int panjang = 5;
        int tinggi = 4;

        Console.WriteLine(5);

        ////////////
        // * * * * * 
        // * * * * * 
        // * * * * * 
        // * * * * * 

        int t = 0;

        Console.WriteLine(t < tinggi);

        while (t < tinggi)
        {
            int p = 0;
            while (p < panjang)
            {
                Console.Write("* ");
                p++;
            }
            Console.WriteLine();
            t++;
        }
    }

    static void Main1(string[] args)
    {
        int i = 10;
        Console.WriteLine(i + 5 + "HALO" + i + 5);
        Console.WriteLine("Halo" + "ADF");

        int[] numbers = new int[10];
        int[] numbers1 = new int [] { 5, 2, 1, 10, 2, 3, };
        
        for (int j = 0; j < numbers1.Length; j++)
        {
            Console.WriteLine(numbers1[j]);
        }

        foreach (int n in numbers1)
        {
            Console.WriteLine(n);
        }
    }
}