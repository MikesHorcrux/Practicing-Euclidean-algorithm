using System;

namespace Practicing_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
        //Euclidean
            Console.WriteLine("Euclidean Example");
            GCD euclidean = new GCD();
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("greatest common divisor is: " + euclidean.gcd(a, b));        }
    }
}
