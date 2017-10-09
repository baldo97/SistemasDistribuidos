using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Program
    {
        public delegate void Print(int value);
        public delegate int Sum(int x,int y);


        static void Main(string[] args)
        {
            String x = "";
            List<String> y = null;

            Print printDelegate = PrintNumber;

            printDelegate(500);
            printDelegate(1000);

            printDelegate = PrintMoney;

            printDelegate(30);

 
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void PrintNumber(int value)
        {
            Console.Out.WriteLine("Print Number " + value);
        }

        public static void PrintMoney(int value)
        {
            Console.Out.WriteLine("Print Money " + value);
        }


        public static void PrintHelper(Print delegateFunc,int numToprint)
        {
            delegateFunc(numToprint);
        }
    }
}
