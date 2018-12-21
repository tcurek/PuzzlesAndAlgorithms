using System.Text;

namespace PuzzlesAndAlgorithms.Exercises
{
    public class ReverseString
    {
        public string GetReversedString(string input)
        {
            var result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}
