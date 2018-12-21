namespace PuzzlesAndAlgorithms.Exercises
{
    public class Fibanocci
    {
        /*
         * Each number is the sum of the 2 preceding numbers.
         *
         * Ex: 0 1 1 2 3 5 8 13
         */

        public int[] GenerateFibanocci(int numberOfRecords)
        {
            if (numberOfRecords < 2)
                return new[]{0};

            var result = new int[numberOfRecords];
            result[0] = 0;
            result[1] = 1;

            for (var i = 2; i <= (numberOfRecords - 1); i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            
            return result;
        }
    }
}
