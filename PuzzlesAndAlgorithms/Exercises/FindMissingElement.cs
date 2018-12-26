namespace PuzzlesAndAlgorithms.Exercises
{
    /*
     * Given 2 arrays as args. There will be one less element in 2 then 1 array. Find missing. Not in same order.     *
     */

    public class MissingElement
    {
        public int FindMissingElement(int[] originalArr, int[] missingElementArr)
        {
            for (var i = 0; i < originalArr.Length; i++)
            {
                var found = false;

                for (var j = 0; j < missingElementArr.Length; j++)
                {
                    if (originalArr[i] == j)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) return i;
            }

            return -1;
        }
    }
}
