namespace coding_practice_dotnet;

public class TreeNode(int val)
{
  public int Value { get; } = val;
  public TreeNode? Left { get; set; }
  public TreeNode? Right { get; set; }
}
