using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("please enter a number");

            int  num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number");

            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("num1 is greater");
            else

                Console.WriteLine("num2 is greater");

            if (num1 == num2) 
            Console.WriteLine("both are equal");

            Console.ReadLine();

           



            

        }
    }
}
