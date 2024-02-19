// Tree
// Find in binarty tree
// Find in sorted 2d array
// Battleship LLD design
// Rate Limited LLD


internal class Program
{
  private static void Main(string[] args)
  {
    // Binary Search
    BinarySearch bs = new BinarySearch();
    Console.WriteLine(bs.Search(nums: [1, 2, 3, 4, 5, 6], target: 5));
    Console.WriteLine(bs.Search(nums: [1, 2, 3, 4, 5, 6], target: 10));
  }
}
