
  //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }

    /// <summary>
    /// Traverse a Binary Tree via InOrder traversal.
    /// </summary>
    /// <param name="root">The first Node in the Binary Tree</param>
    /// <returns>A List that contains all node values, in correct order</returns>
    public IList<int> InorderTravesal(TreeNode root)
    {
        TreeNode currentNode = root;
        IList<int> solution = new List<int>();

        while(currentNode.left != null)
        {
            solution.Insert(0, currentNode.val); 
            currentNode = currentNode.left;
        }
        


        return solution;
        
    }
  }
 