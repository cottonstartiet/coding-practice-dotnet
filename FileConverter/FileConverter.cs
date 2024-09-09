
namespace coding_practice_dotnet.FileConverter
{
    internal class FileConverter
    {
        private readonly FileConverterProvider fileConvertersProvider;

        public FileConverter(FileConverterProvider fileConverterProvider)
        {
            fileConvertersProvider = fileConverterProvider;
        }

        internal string ConvertFile(string srcFile, FileType srcFileType, FileType destFileType)
        {
            IEnumerable<Converters.IFileConverter> converters = fileConvertersProvider.GetConverters(srcFile, destFileType);
            string tempFile = srcFile;

            foreach (Converters.IFileConverter converter in converters)
            {
                tempFile = converter.ConvertFile(tempFile);
            }

            return tempFile;
        }
    }
}
