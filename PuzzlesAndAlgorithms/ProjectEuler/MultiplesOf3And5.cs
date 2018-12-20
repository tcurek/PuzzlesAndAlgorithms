using System.Collections.Generic;
using System.Linq;

namespace PuzzlesAndAlgorithms.ProjectEuler
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5,
     * we get 3, 5, 6 and 9. The sum of these multiples is 23.
     *
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    public class MultiplesOf3And5
    {
        public int GetMultiplesOf3And5(int bounds)
        {
            var values = new List<int>();

            var multipleOf3 = 3;
            var multipleOf5 = 5;

            while (multipleOf3 < bounds)
            {
                values.Add(multipleOf3);
                multipleOf3 += 3;

            }

            while (multipleOf5 < bounds)
            {
                values.Add(multipleOf5);
                multipleOf5 += 5;
            }

            return values.Distinct().Sum();
        }
    }
}
