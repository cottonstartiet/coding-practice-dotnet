namespace coding_practice_dotnet.Models
{
    internal class Directory(string name)
    {
        public string Name { get; } = name;
        public List<File> Files { get; } = [];
    }
}
