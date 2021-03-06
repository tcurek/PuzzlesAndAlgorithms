﻿namespace PuzzlesAndAlgorithms.ProjectEuler
{
    public class SumOfEvenFibonacci
    {
        /*
         * Each new term in the Fibonacci sequence is generated by adding the previous two terms.
         * By starting with 1 and 2, the first 10 terms will be:
         *
         * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
         * By considering the terms in the Fibonacci sequence whose values do not exceed four million,
         * find the sum of the even-valued terms.
         */

        public int GetSumOfEvenFibonacci(int bounds)
        {
            int lower = 1;
            int upper = 2;

            if (upper > bounds)
                return 0;

            int result = upper;

            while (upper <= bounds)
            {
                var value = lower + upper;

                if (value % 2 == 0)
                {
                    result += value;
                };

                lower = upper;
                upper = value;
            }

            return result;
        }
    }
}
