// Keyboard distance
using coding_practice_dotnet;
using coding_practice_dotnet.DSA;

// Console.WriteLine($"Typing distance: {KeyboardDistance.CalculateTime("cba")}");
// Console.WriteLine($"Typing distance: {KeyboardDistance.CalculateTime("zyx")}");

// Console.WriteLine($"Is two sum: {TwoSum.IsTwoSum([1, 2, 3, 4, 5], 9)}");
// Console.WriteLine($"Is two sum: {TwoSum.IsTwoSum([1, 2, 3, 4, 5], 10)}");

SimpleMinHeap minHeap = new SimpleMinHeap();
minHeap.AddItem(new Student("aseem", 1));
minHeap.AddItem(new Student("gaurav", 2));
minHeap.AddItem(new Student("jyoti", 5));
minHeap.AddItem(new Student("bundela", 4));
minHeap.AddItem(new Student("sia", 3));


minHeap.Display();
