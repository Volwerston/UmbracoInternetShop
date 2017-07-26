using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public List<TreeNode> GetTrees(int n)
        {
            List<TreeNode> toReturn = new List<TreeNode>();

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; ++i) arr[i] = i + 1;

            return GetBST(arr, 0, arr.Length - 1);
        }

        public List<TreeNode> GetBST(int[] arr, int start, int end)
        {
            if (start > end) return new List<TreeNode>();
            else if (start == end) return new List<TreeNode> { new TreeNode(arr[start]) };

            List<TreeNode> toReturn = new List<TreeNode>();

            for(int i = start; i <= end; ++i)
            {
                List<TreeNode> left = GetBST(arr, start, i - 1);
                List<TreeNode> right = GetBST(arr, i + 1, end);

                if(left.Count() == 0 && right.Count() > 0)
                {
                    for (int j = 0; j < right.Count(); ++j)
                    {
                        TreeNode n = new TreeNode(arr[i]);
                        n.right = right[j];
                        toReturn.Add(n);
                    }
                }
                else if(left.Count() > 0 && right.Count() == 0)
                {
                    for (int j = 0; j < left.Count(); ++j)
                    {
                        TreeNode n = new TreeNode(arr[i]);
                        n.left = left[j];
                        toReturn.Add(n);
                    }
                }
                else
                {
                    for(int j = 0; j < left.Count(); ++j)
                    {
                        for(int l = 0; l < right.Count(); ++l)
                        {
                            TreeNode n = new TreeNode(arr[i]);
                            n.left = left[j];
                            n.right = right[l];
                            toReturn.Add(n);
                        }
                    }
                }
            }

            return toReturn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<TreeNode> n = new Solution().GetTrees(10);

            Console.ReadKey();
        }
    }
}
