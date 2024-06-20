// Battleship LLD design
// Rate limiter LLD

using coding_practice_dotnet;

// Binary Search
// BinarySearch bs = new BinarySearch();
// Console.WriteLine(bs.Search([1, 2, 3, 4, 5, 6], 5));
// Console.WriteLine(bs.Search([1, 2, 3, 4, 5, 6], 10));

//TreeNode bstRoot4 = new(4);
//TreeNode node1 = new(1);
//TreeNode node2 = new(2);
//TreeNode node3 = new(3);
//TreeNode node5 = new(5);
//TreeNode node6 = new(6);
//TreeNode node7 = new(7);
//node2.Left = node1;
//node2.Right = node3;
//node6.Left = node5;
//node6.Right = node7;
//bstRoot4.Left = node2;
//bstRoot4.Right = node6;

// Inorder tarversal
// InorderTraversal inorderTraversal = new();
// inorderTraversal.Traverse(bstRoot4);

// Find max path sum
// MaxPathSum maxPathSum = new();
// Console.WriteLine(maxPathSum.FindMaxPathSum(bstRoot4));

// Find in sorted 2d array
// int[][] array = [
//   [1,2,3],
//   [4,5,6],
//   [7,8,9],
// ];
// FindInSortedArray findInSortedArray = new();
// Console.WriteLine(findInSortedArray.FindBinarySearch(array, 6));
// Console.WriteLine(findInSortedArray.FindDfs(array, 3));

VirtualFileSystemCollections vfsc = new();
vfsc.CreateFile("one.txt", 10, ["personal", "finance", "simple"]);
vfsc.CreateFile("two.txt", 20, ["personal", "simple"]);
vfsc.CreateFile("three.txt", 30, ["finance", "simple"]);
Logger.Log(vfsc.GetTopKCollections(1));
Logger.Log(vfsc.GetTopKCollections(2));
Logger.Log(vfsc.GetAllFiles());
Logger.Log(vfsc.GetTotalSize());