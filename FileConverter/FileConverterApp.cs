
namespace coding_practice_dotnet.FileConverter
{
    internal class FileConverterApp
    {
        public bool ConvertFile(FileType srcFileType, string srcFilePath, FileType destFileType, string destFilePath)
        {
            if (CanConvert(srcFileType, destFileType))
            {
                _ = GetConverters(srcFileType, destFilePath);

            }

            return false;
        }

        private object GetConverters(FileType srcFileType, string destFilePath)
        {
            throw new NotImplementedException();
        }

        private bool CanConvert(FileType srcFileType, FileType destFileType)
        {
            throw new NotImplementedException();
        }
    }
}
