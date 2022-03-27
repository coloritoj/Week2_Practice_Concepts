using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Anonymous_Functions
{
    class Program
    {
        public delegate void BirthdayDelegate(string name, int age);

        public delegate string RestaurantDelegate(string restaurant, int rating);

        static string RestaurantInfo(string restaurant, int rating)
        {
            return $"{restaurant} is rated {rating} stars on Yelp!";
        }

        public delegate void HelloWorldDelegate();

        static void Main(string[] args)
        {
            // ============================================================
            // The last item in Func<> is the return type.
            // In this case, Func<int, bool> returns a bool.
            Func<int, bool> isGreaterThan5 = i => i > 5;
            Console.WriteLine(isGreaterThan5(4)); // Evaluates to false
            Console.WriteLine(isGreaterThan5(5)); // Evalutes to false
            Console.WriteLine(isGreaterThan5(6)); // Evaluates to true
            // ============================================================





            // ============================================================
            // This takes in a string and an int
            // It parses the string to an int and then compares the two numbers
            // If the two numbers are the same, it returns true
            // If the two numbers are not the same, it returns false
            Func<string, int, bool> stringTest = (myString, myNumber) => int.Parse(myString) == myNumber;

            Console.Write("Are '10' and 10 the same?: ");
            Console.WriteLine(stringTest("10", 10)); // Evaluates to true

            Console.Write("Are '9' and 10 the same?: ");
            Console.WriteLine(stringTest("9", 10)); // Evaluates to false
            // ============================================================





            // ============================================================
            // This takes in a bool and if it's true, it returns 9001
            // If the bool is false, it returns 0
            Func<bool, int> ifTrueReturn9001 = i => { if (i) { return 9001; } else { return 0; } };
            Console.WriteLine(ifTrueReturn9001(true));
            Console.WriteLine(ifTrueReturn9001(false));
            // ============================================================





            // ============================================================
            // BirthdayDelegate returns void
            BirthdayDelegate bday = (string name, int age) => Console.WriteLine($"Happy birthday {name}! You are {age}!");
            bday("Josh", 30);
            // ============================================================





            // ============================================================
            // RestaurantDelegate returns a string
            RestaurantDelegate restaurantInfo = RestaurantInfo;
            Console.WriteLine(restaurantInfo("Red Lobster", 4));
            // ============================================================





            // ============================================================
            HelloWorldDelegate helloWorld = () => Console.WriteLine("Hello world!");
            helloWorld.Invoke();
            // ============================================================





            Console.ReadLine();
        }
    }
}
