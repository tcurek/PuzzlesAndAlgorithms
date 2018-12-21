namespace PuzzlesAndAlgorithms.Exercises
{
    public class ReverseString
    {
        public string GetReversedString(string input)
        {
            var result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }
    }
}
