namespace coding_practice_dotnet.FileConverter.Converters
{
    internal interface IFileConverter
    {
        FileType SourceFileType { get; }
        FileType DestinationFileType { get; }
        string ConvertFile(string srcFile);
    }
}
