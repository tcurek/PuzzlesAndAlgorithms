using System;

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

        /*
         * Write a function that reverses a string. The input string is given as an array of characters char[].
         * Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
         * You may assume all the characters consist of printable ascii characters.
         *
         * Example: Input: ["h","e","l","l","o"], Output: ["o","l","l","e","h"]
         */

        public static char[] ReverseString(char[] s)
        {
            if (s.Length < 2)
            {
                return s;
            }

            return Helper(s, 0, s.Length - 1);
        }

        public static char[] Helper(char[] s, int left, int right)
        {
            if (left < right)
            {
                var lastChar = s[right];
                s[right] = s[left];
                s[left] = lastChar;
                Helper(s, left + 1, right - 1);
            }

            return s;
        }
    }
}
