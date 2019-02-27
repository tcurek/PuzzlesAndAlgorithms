using System;

namespace PuzzlesAndAlgorithms.ProjectEuler
{
    public class PrimeFactors
    {
        public long FindLargestPrimeFactorOf(long number)
        {
            if (number % 2 == 0)
                number -= 1;

            for (long i = 1; i <= number; i++)
            {
                var result = number / i;

                if (IsPrime(result))
                    return result;
            }

            return -1;
        }

        private static bool IsPrime(long value)
        {
            for (long j = 2; j < value; j+=2)
            {
                if (value % j == 0)
                    return false;
            }

            return true;
        }


        public long maxPrimeFactors(long n)
        {
            // Initialize the maximum prime 
            // factor variable with the 
            // lowest one 
            long maxPrime = -1;

            // Print the number of 2s 
            // that divide n 
            while (n % 2 == 0)
            {
                maxPrime = 2;

                // equivalent to n /= 2 
                n >>= 1;
            }

            // n must be odd at this point, 
            // thus skip the even numbers 
            // and iterate only for odd 
            // integers 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n = n / i;
                }
            }

            // This condition is to handle 
            // the case when n is a prime 
            // number greater than 2 
            if (n > 2)
                maxPrime = n;

            return maxPrime;
        }
    }
}
