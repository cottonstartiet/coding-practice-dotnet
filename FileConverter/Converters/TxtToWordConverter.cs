namespace coding_practice_dotnet.FileConverter.Converters
{
    internal class TxtToWordConverter : IFileConverter
    {
        public FileType SourceFileType => FileType.Txt;

        public FileType DestinationFileType => FileType.Word;

        public string ConvertFile(string srcFile)
        {
            string destFile = srcFile + "->word";
            return destFile;
        }
    }
}
