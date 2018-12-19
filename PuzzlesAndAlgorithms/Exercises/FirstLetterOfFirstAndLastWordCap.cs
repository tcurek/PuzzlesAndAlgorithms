using System.Text;

namespace PuzzlesAndAlgorithms.Exercises
{
    public class FirstLetterOfFirstAndLastWordCap
    {
        /*
         * Capitalize first letter of first word.
         * Capitalize first letter of last word.
         * All other words/letters should be lower cased.
         */

        public string CapitalizeFirstLetterOfFirstAndLastWord(string initial)
        {
            if (string.IsNullOrEmpty(initial))
                return initial;

            initial = initial.ToLower();
            var listOfWords = initial.Split(" ");
            var finalOutput = new StringBuilder();

            finalOutput.Append(char.ToUpper(listOfWords[0][0]) + listOfWords[0].Substring(1));

            for (int i = 1; i < listOfWords.Length - 1; i++)
            {
                finalOutput.Append(" " + listOfWords[i]);
            }

            finalOutput.Append(" ");
            finalOutput.Append(char.ToUpper(listOfWords[listOfWords.Length - 1][0]) + listOfWords[listOfWords.Length - 1].Substring(1));

            return finalOutput.ToString();
        }
    }
}
