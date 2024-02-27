// Tree
// Find in binarty tree
// Find in sorted 2d array
// Battleship LLD design
// Rate Limited LLD
// Binary Search


internal class FindInSortedArray
{
  public FindInSortedArray()
  {
  }

  internal bool FindBinarySearch(int[][] array, int target)
  {
    bool found = false;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i][0] <= target && target <= array[i][array.Length - 1])
      {
        found = FindTargetBinarySearch(array, i, target);
      }
    }

    return found;
  }

  private bool FindTargetBinarySearch(int[][] array, int i, int target)
  {
    int left = 0;
    int right = array[i].Length - 1;
    while (left <= right)
    {
      int mid = (left + right) / 2;
      if (array[i][mid] == target)
      {
        return true;
      }
      else if (array[i][mid] < target)
      {
        left = mid + 1;
      }
      else
      {
        right = mid - 1;
      }
    }

    return false;
  }

  internal bool FindDfs(int[][] array)
  {
    return false;
  }
}




