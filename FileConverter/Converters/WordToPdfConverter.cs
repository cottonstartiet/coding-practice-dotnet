namespace coding_practice_dotnet.FileConverter.Converters
{
    internal class WordToPdfConverter : IFileConverter
    {
        public FileType SourceFileType => FileType.Word;

        public FileType DestinationFileType => FileType.Pdf;

        public string ConvertFile(string srcFile)
        {
            string destFile = srcFile + "->pdf";
            return destFile;
        }
    }
}
