
using coding_practice_dotnet.FileConverter.Converters;

namespace coding_practice_dotnet.FileConverter
{
    internal class FileConverterProvider
    {
        private readonly Dictionary<string, IFileConverter> fileConverters = [];

        public void RegisterConverter(FileType srcType, FileType destType, IFileConverter converter)
        {
            string key = GetConverterKey(srcType, destType);
            fileConverters.Add(key, converter);
        }

        private string GetConverterKey(FileType srcType, FileType destType)
        {
            return srcType.ToString() + destType.ToString();
        }

        public void Build()
        {
            InitFileConvertersGraph(fileConverters);
        }

        private void InitFileConvertersGraph(Dictionary<string, IFileConverter>? _)
        {
            return;
        }

        internal IList<IFileConverter> GetConverters(string srcFile, FileType destFileType)
        {
            return [
                fileConverters[GetConverterKey(FileType.Txt, FileType.Word)],
                fileConverters[GetConverterKey(FileType.Word, FileType.Pdf)]
            ];
        }
    }
}