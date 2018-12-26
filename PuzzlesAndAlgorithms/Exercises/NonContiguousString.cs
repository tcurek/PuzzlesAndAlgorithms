using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlesAndAlgorithms.Exercises
{
    public class NonContiguousString
    {
        /*
         * 2 params of string.
         *
         * Find largest match
         *
         * EXAMPLE: "tim", "jim"
         *
         *   | 0 j i m
         * ---------
         * 0 | 0 0 0 0
         * t | 0 0 0 0
         * i | 0 0 1 0
         * m | 0 0 0 2
         */


        public string LargestCommonStringGood(string x, string y)
        {
            int m = x.Length;
            int n = y.Length;

            var L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i,j] = 0;
                    }
                    else if (x[i - 1] == y[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                    }
                }
            }

            int index = L[m, n];
            int temp = index;

            char[] lcs = new char[index+1];

            lcs[index] = '\0';

            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                if (x[k - 1] == y[l - 1])
                {
                    lcs[index - 1] = x[k - 1];

                    k--;
                    l--;
                    index--;
                }
                else if (L[k-1, l] > L[k,l-1])
                {
                    k--;
                }
                else
                {
                    l--;
                }
            }

            return new string(lcs.Take(lcs.Length-1).ToArray());
        }
    }
}
