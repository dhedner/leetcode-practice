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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        if (root == null)
        {
            return list;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            list.Insert(0, node.val);

            if (node.left != null)
            {
                stack.Push(node.left);
            }

            if (node.right != null)
            {
                stack.Push(node.right);
            }
        }

        return list;
    }
}
