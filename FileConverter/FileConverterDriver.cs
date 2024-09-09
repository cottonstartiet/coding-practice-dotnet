using coding_practice_dotnet.FileConverter.Converters;

namespace coding_practice_dotnet.FileConverter
{
    internal class FileConverterDriver
    {
        public static void Run()
        {
            FileConverterProvider fileConverterProvider = new();
            fileConverterProvider.RegisterConverter(FileType.Txt, FileType.Word, new TxtToWordConverter());
            fileConverterProvider.RegisterConverter(FileType.Word, FileType.Pdf, new WordToPdfConverter());
            fileConverterProvider.Build();

            FileConverter fileConverter = new(fileConverterProvider);
            string finalFile = fileConverter.ConvertFile("one.txt", FileType.Txt, FileType.Pdf);

            Console.WriteLine("Final converted file is: " + finalFile);
        }
    }
}
