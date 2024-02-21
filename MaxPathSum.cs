using coding_practice_dotnet;

internal class MaxPathSum
{
  private int maxSum = int.MinValue;
  public MaxPathSum()
  {
  }

  internal int FindMaxPathSum(TreeNode node)
  {
    FindMaxPathSum(node, 0);
    return maxSum;
  }

  private void FindMaxPathSum(TreeNode node, int currentSum)
  {
    if (node == null)
    {
      return;
    }

    int newSum = currentSum + node.Value;

    maxSum = maxSum > newSum ? maxSum : newSum;

    if (node.Left != null)
    {
      FindMaxPathSum(node.Left, newSum);
    }

    if (node.Right != null)
    {
      FindMaxPathSum(node.Right, newSum);
    }
  }
}




