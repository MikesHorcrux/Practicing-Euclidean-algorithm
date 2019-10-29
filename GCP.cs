using System;
namespace Practicing_algorithms
{
    public class GCD
    {

        public int gcd(int a, int b)
        {
            //find the greatest common Denominatior of two numbers 
            //using Euclids Algorithum 
            if (a == 0)
            {
                return b;
            }
            return gcd(b % a, a);
        }

    }
}
