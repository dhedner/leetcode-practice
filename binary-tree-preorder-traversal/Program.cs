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
    public IList<int> AddRecursive(TreeNode root, IList<int> list)
    {
        if (root == null)
        {
            return list;
        }

        list.Add(root.val);
        AddRecursive(root.left, list);
        AddRecursive(root.right, list);

        return list;
    }

    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        return AddRecursive(root, list);
    }
}