using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapNumber<int> sn = new SwapNumber<int>();
            Console.WriteLine("Enter Number1:");
            sn.number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2:");
            sn.number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------Swapping Numbers-------");
            sn.swap();
            Console.WriteLine("Number 1: " + sn.number1 + "\nNumber2: " + sn.number2);

            Console.ReadLine();
        }
    }
}
