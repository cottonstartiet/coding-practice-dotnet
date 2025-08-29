using System;

namespace coding_practice_dotnet;

public class Student(string name, int rank)
{
    public string Name { get; set; } = name;
    public int Rank { get; set; } = rank;
}

public class SimpleMinHeap
{
    private readonly PriorityQueue<Student, int> heap = new(Comparer<int>.Create((x, y) => x - y));

    public void AddItem(Student student)
    {
        heap.Enqueue(student, student.Rank);
    }

    public void Display()
    {
        while (heap.Count > 0)
        {
            var val = heap.TryDequeue(out Student? student, out int rank);
            Console.WriteLine($"Name: {student?.Name}, Rank: {rank}");
        }
    }
}
