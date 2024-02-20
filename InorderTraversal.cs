// Tree
// Find in binarty tree
// Find in sorted 2d array
// Battleship LLD design
// Rate Limited LLD
// Binary Search
using coding_practice_dotnet;

internal class InorderTraversal
{
  public InorderTraversal()
  {
  }

  internal void Traverse(TreeNode node)
  {
    if (node == null)
    {
      return;
    }

    if (node.Left != null)
    {
      Traverse(node.Left);
    }
    Console.WriteLine(node.Value);
    if (node.Right != null)
    {
      Traverse(node.Right);
    }
  }
}




