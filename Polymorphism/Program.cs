using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer = new PrinterWindows();

            Console.WriteLine("muh. firdaus f.(19.11.2789)");
            Console.WriteLine();
            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1 ... 3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

                if (nomorPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (nomorPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }

}
