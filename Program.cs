// Tree
// Find in binarty tree
// Find in sorted 2d array
// Battleship LLD design
// Rate Limited LLD
// Binary Search
using coding_practice_dotnet;

// Binary Search
// BinarySearch bs = new BinarySearch();
// Console.WriteLine(bs.Search([1, 2, 3, 4, 5, 6], 5));
// Console.WriteLine(bs.Search([1, 2, 3, 4, 5, 6], 10));

int[][] array = [
  [1,2,3],
  [4,5,6],
  [7,8,9],
];
FindInSortedArray findInSortedArray = new();
Console.WriteLine(findInSortedArray.FindBinarySearch(array));
Console.WriteLine(findInSortedArray.FindDfs(array));


TreeNode bstRoot4 = new(4);
TreeNode node1 = new(1);
TreeNode node2 = new(2);
TreeNode node3 = new(3);
TreeNode node5 = new(5);
TreeNode node6 = new(6);
TreeNode node7 = new(7);
node2.Left = node1;
node2.Right = node3;
node6.Left = node5;
node6.Right = node7;
bstRoot4.Left = node2;
bstRoot4.Right = node6;

InorderTraversal inorderTraversal = new();
inorderTraversal.Traverse(bstRoot4);

MaxPathSum maxPathSum = new();
maxPathSum.FindMaxPathSum(bstRoot4);




