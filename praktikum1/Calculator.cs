using System;

namespace TugasCalculator
{
    class Calculator
    {
        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih Menu Calculator ");
            Console.WriteLine();

            Console.WriteLine("1. Penambahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian ");
            Console.WriteLine();

            Console.WriteLine("Inputkan Nomor Menu [1..4] ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Inputkan Nilai B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menu == 1)
            {
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
                Console.WriteLine();

                Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
                Console.ReadKey();
            }
            else if (menu == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                Console.WriteLine();

                Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
                Console.ReadKey();
            }
            else if (menu == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                Console.WriteLine();

                Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
                Console.ReadKey();
            }
            else if (menu == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                Console.WriteLine();

                Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia!!");
                Console.WriteLine();

                Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
                Console.ReadKey();
            }
        }
    }
}
