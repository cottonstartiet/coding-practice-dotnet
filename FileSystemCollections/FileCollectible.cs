namespace coding_practice_dotnet.FileSystemCollections
{
    internal class FileCollectible
    {
        public string Name { get; init; }
        public int Size { get; init; }
        public IList<string> Collections { get; init; } = [];

        override public string ToString()
        {
            return $"Name: {Name}, Size: {Size}, Collections: {Collections}";
        }
    }
}
