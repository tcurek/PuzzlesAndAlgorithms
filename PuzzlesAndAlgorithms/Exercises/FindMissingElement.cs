using System.Linq;

namespace PuzzlesAndAlgorithms.Exercises
{
    /*
     * Given 2 arrays as args. There will be one less element in 2 then 1 array. Find missing. Not in same order.     *
     */

    public class MissingElement
    {
        // O(n^2)
        public int FindMissingElementBad(int[] originalArr, int[] missingElementArr)
        {
            for (var i = 0; i < originalArr.Length; i++)
            {
                var found = false;

                for (var j = 0; j < missingElementArr.Length; j++)
                {
                    if (originalArr[i] == missingElementArr[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) return originalArr[i];
            }

            return -1;
        }

        // O(n)
        public int FindMissingElementGood(int[] originalArr, int[] missingElementArr)
        {
            return originalArr.Sum() - missingElementArr.Sum();
        }
    }
}
