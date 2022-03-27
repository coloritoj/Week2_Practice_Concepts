using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Josh Colorito");

            AddTwoNumbers(4, 6);

            MakeUppercase("hello world!");

            Console.ReadLine();
        }

        static void GreetUser(string name) => Console.WriteLine($"Hello {name}");

        static void AddTwoNumbers(int num1, int num2) => Console.WriteLine(num1 + num2);

        static void MakeUppercase(string text) => Console.WriteLine((text).ToUpper());
    }
}
