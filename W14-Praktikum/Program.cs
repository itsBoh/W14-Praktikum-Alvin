using System;

namespace W14_Praktikum
{
    internal class Program
    {
        static  void Prima(int input)
        {
            int angka = 1;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    int cek = 0;
                    while (cek != 1)
                    {
                        angka++;
                        int x = 1;
                        int b;
                        do
                        {
                            x++;
                            b = angka % x;
                        } while (b != 0);
                        if (angka == x)
                            cek = 1;
                    }
                    Console.Write("{0,6}", angka);
                }
                Console.WriteLine();
            }
        }
        static void bukanPrima(int input)
        {
            int angka = 0;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    int cek = 0;
                    while (cek != 1)
                    {
                        angka++;
                        if (angka == 1)
                            break;
                        int x = 1;
                        int b;
                        do
                        {
                            x++;
                            b = angka % x;
                        } while (b != 0);
                        if (angka != x)
                            cek = 1;
                    }
                    Console.Write("{0,6}", angka);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            int b;
            string hasil = null;
            while(true)
            {
                if (input < 2)
                    hasil = "bukanPrima";
                else
                {
                    b = input % a;
                    if (b == 0)
                    {
                        if (input == a)
                            hasil = "prima";
                        else
                            hasil = "bukanPrima";
                    }
                    else
                        a++;
                }
                if (hasil == "prima" || hasil == "bukanPrima")
                    break;
            }
            Console.WriteLine("Output : ");
            if (hasil == "prima")
                Prima(input);
            else if (hasil == "bukanPrima")
                bukanPrima(input);
        }
    }
}
