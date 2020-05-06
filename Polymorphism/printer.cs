using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
        public virtual void Error()
        {
            Console.WriteLine("Error ");
        }
    }
}
