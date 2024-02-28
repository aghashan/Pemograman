using System;

namespace CalculatorConsoleApp
{
	class Program
	{
		static int Penambahan(int a, int b)
		{
			return a + b;
		}

		static int Pengurangan(int a, int b)
		{
			return a - b;
		}

		static int Perkalian(int a, int b)
		{
			return a * b;
		}

		static double Pembagian(int a, int b)
		{
			return (double)a / b;
		}

		static void Main(string[] args)
		{
			Console.Title = "Aplikasi Calculator";

			Console.WriteLine("Inputkan Nilai A = ");
			int a = int.Parse(Console.ReadLine());

			Console.WriteLine("Inputkan Nilai B = ");
			int b = int.Parse(Console.ReadLine());

			Console.WriteLine();

			Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
			Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
			Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
			Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
			Console.WriteLine();

			Console.WriteLine("Tekan Sembarang Key Untuk Keluar ");
			Console.WriteLine(Console.ReadKey());
		}
	}
}
