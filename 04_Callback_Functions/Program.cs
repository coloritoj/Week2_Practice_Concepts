using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Callback_Functions
{
    class Program
    {
        // 01: Think of the delegate as an interface
        // It's basically saying, "You can pass in a method with this signature"
        public delegate void MathDelegate(string answer);

        // 02: The MathAnswer method matches the MathDelegate signature
        // i.e.: void MathAnswer(string answer) = void MathDelegate(string answer)
        public static void MathAnswer(string answer)
        {
            Console.WriteLine(answer);
        }

        // 03: The MathMethodWithCallback method has a signature that takes in two ints and a MathDelegate delegate
        public static void MathMethodWithCallback(int num1, int num2, MathDelegate mathDel)
        {
            // 04: The delegate function needs to pass a string as a parameter, which is what's going on here
            mathDel($"The sum of your numbers is {num1 + num2}");
        }

        static void Main(string[] args)
        {
            // 05: The MathMethodWithCallback is taking in two ints and the MathAnswer function since it matches the signature of the MathDelegate delegate
            MathMethodWithCallback(4, 22, MathAnswer);
            Console.ReadLine();
        }
    }
}
