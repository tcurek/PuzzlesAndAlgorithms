namespace PuzzlesAndAlgorithms.LeetCode.Recursion
{
    public static class RecursiveReverseString
    {
        /*
         * Using recursion. reverse the characters in the string parameter.
         *
         *  Param: Tim
         *  returns: miT
         *
         *  ** Dont use string builder... ignore for this case
         */
         
        public static string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            var lastChar = str[str.Length - 1].ToString();

            if (str.Length > 1)
            {
                lastChar += Reverse(str.Substring(0, str.Length - 1));
            }

            return lastChar;
        }
    }
}
