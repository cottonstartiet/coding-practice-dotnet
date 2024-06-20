// Battleship LLD design
// Rate limiter LLD


using coding_practice_dotnet;
using coding_practice_dotnet.FileSystemCollections;

internal class VirtualFileSystemCollections
{
    public int TotalSize { get; private set; }
    private readonly IList<FileCollectible> files = [];
    private readonly Dictionary<string, int> fileCollectionSizes = [];

    internal void Run()
    {
        CreateFile("one.txt", 10, ["personal", "finance", "simple"]);
        CreateFile("two.txt", 20, ["personal", "simple"]);
        CreateFile("three.txt", 30, ["finance", "simple"]);
        Console.WriteLine("get top 1");
        Logger.Log(GetTopKCollections(1));
        Console.WriteLine("get top 2");
        Logger.Log(GetTopKCollections(2));
        Console.WriteLine("get all");
        Logger.Log(GetAllFiles());
        Console.WriteLine("get size");
        Logger.Log(TotalSize);
        Console.WriteLine("Collection sizes");
        DisplayAllCollectionSizes();
    }

    internal void CreateFile(string name, int size, IList<string> collections)
    {
        var file = new FileCollectible { Name = name, Size = size, Collections = collections };
        TotalSize += size;
        files.Add(file);

        foreach (var collection in collections)
        {
            if (fileCollectionSizes.ContainsKey(collection))
            {
                fileCollectionSizes[collection] += size;
            }
            else
            {
                fileCollectionSizes.Add(collection, size);
            }
        }
    }

    internal IList<FileCollectible> GetAllFiles()
    {
        return files;
    }

    internal IEnumerable<string> GetTopKCollections(int k)
    {
        return fileCollectionSizes.OrderByDescending(kv => kv.Value).Take(k).Select(kv => kv.Key).ToList();
    }

    internal void DisplayAllCollectionSizes()
    {
        foreach (var kv in fileCollectionSizes)
        {
            Console.WriteLine($"Collection: {kv.Key}, Size: {kv.Value}");
        }
    }
}