// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public class Solution
{
    public int GetHeight(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
    }

    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        int diff = GetHeight(root.left) - GetHeight(root.right);

        if (Math.Abs(diff) <= 1)
        {
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        else
        {
            return false;
        }
    }
}