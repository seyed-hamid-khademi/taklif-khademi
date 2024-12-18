using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrange
{
    class Program
    {
        static void Main(string[] args)
        {
//          +-----------------------------+       
//          |          Variables          |
//          +-----------------------------+
            double num1;
            double num2;
            double num3;

//          +-----------------------------+       
//          |           Inputs            |
//          +-----------------------------+
            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            num1 = double.Parse(a);

            Console.WriteLine("Now enter an other");
            string b = Console.ReadLine();
            num2 = double.Parse(b);

            Console.WriteLine("And an other one");
            string c = Console.ReadLine();
            num3 = double.Parse(c);

//          +-----------------------------+       
//          |          Functions          |
//          +-----------------------------+
            if (num1 > num2 && num1 > num3 && num2 > num3)
                Console.WriteLine(num1 + ", " + num2 + ", " + num3);
            if (num1 > num2 && num1 > num3 && num2 <= num3)
                Console.WriteLine(num1 + ", " + num3 + ", " + num2);
            if (num1 <= num2 && num1 > num3 && num2 > num3)
                Console.WriteLine(num2 + ", " + num1 + ", " + num3);
            if (num1 <= num2 && num1 <= num3 && num2 > num3)
                Console.WriteLine(num2 + ", " + num3 + ", " + num1);
            if (num1 > num2 && num1 <= num3 && num2 <= num3)
                Console.WriteLine(num3 + ", " + num1 + ", " + num2);
            if (num1 <= num2 && num1 <= num3 && num2 <= num3)
                Console.WriteLine(num3 + ", " + num2 + ", " + num1);

//       ---End-----------------------------       
            Console.ReadKey();
        }
    }
}
