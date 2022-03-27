using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareOutputs("Gamestop", AddIsAwesome);
            Console.ReadLine();
        }

        public delegate void StringDelegate(string text);

        static void AddIsAwesome(string text) => Console.WriteLine($"{text} is awesome!");

        static void CompareOutputs(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            Console.Write("After: ");
            stringDelegate(text);
        }
    }
}
