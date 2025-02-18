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
    bool CheckMirror(TreeNode rightNode, TreeNode leftNode)
    {
        // if both nodes are null, then they are mirror
        if (rightNode == null && leftNode == null)
        {
            return true;
        }

        //  if one of the nodes is null, then they are not mirror
        if (rightNode == null || leftNode == null)
        {
            return false;
        }

        // recursively check both the left and right nodes and their values
        return CheckMirror(rightNode.right, leftNode.left) &&
               CheckMirror(rightNode.left, leftNode.right) &&
               rightNode.val == leftNode.val;
    }

    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return CheckMirror(root.right, root.left);
    }

}
