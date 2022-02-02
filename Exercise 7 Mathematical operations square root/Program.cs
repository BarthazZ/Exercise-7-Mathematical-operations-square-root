using System;

namespace Exercise_7_Mathematical_operations_square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            // A: Ask the user for a number.
            Console.WriteLine("Please enter any number.");

            // B: Remember the number provided by the user.
            int an1 = int.Parse(Console.ReadLine());

            // C: Calculate the square root with the Math.sqrt () method.
            double an2 = Math.Sqrt(an1);

            // D: View the result.
            Console.WriteLine("The square root of z" + an1 + " is: " + an2);
        }
    }
}
