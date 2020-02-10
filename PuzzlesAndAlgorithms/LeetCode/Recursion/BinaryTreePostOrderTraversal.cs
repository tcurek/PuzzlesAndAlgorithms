using System.Collections.Generic;

namespace PuzzlesAndAlgorithms.LeetCode.Recursion
{
    public static class BinaryTreePostOrderTraversal
    {
        /* Given a binary tree, return the postorder traversal of its nodes' values.
         *
         * Input: [1,null,2,3]
         * Output: [3,2,1]
         */

        // Solution 1

        public static IList<int> Solution1(TreeNode root)
        {
            List<int> output = new List<int>();
            PostTraverse(root, output);
            return output;
        }

        private static void PostTraverse(TreeNode root, List<int> valList)
        {
            if (root == null)
            {
                return;
            }

            PostTraverse(root.left, valList);
            PostTraverse(root.right, valList);
            valList.Add(root.val);
        }

        // Solution 2

        //public static IList<int> Solution2(TreeNode root)
        //{
        //    Stack<int> rootStack = new Stack<int>();
        //    var result = new List<int>();

        //    if (root == null)
        //    {
        //        return result;
        //    }

        //    rootStack.Push(root.val);

        //    if (root.left != null)
        //    {
        //        var left = Solution2(root.left);
        //        foreach (var l in left)
        //        {
        //            rootStack.Push(l);
        //        }
        //    }

        //    if (root.right != null)
        //    {
        //        var right = Solution2(root.right);
        //        foreach (var r in right)
        //        {
        //            rootStack.Push(r);
        //        }
        //    }

        //    while (rootStack.TryPop(out var d))
        //    {
        //        result.Add(d);
        //    }
            
        //    return result;
        //}
    }
}
