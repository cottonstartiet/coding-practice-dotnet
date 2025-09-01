using System;
using System.Diagnostics;

namespace coding_practice_dotnet.LowLevelDesigns;

public enum FileTypes
{
    Html,
    Pdf,
    Word,
    Markdown
}

public interface IFileConverter
{
    FileTypes Source { get; }
    FileTypes Destination { get; }
    string Convert(string path);
}

public class HtmlToMarkdownConverter : IFileConverter
{
    public FileTypes Source => FileTypes.Html;

    public FileTypes Destination => FileTypes.Markdown;

    public string Convert(string path)
    {
        return $"{path}->Markdown";
    }
}

public class HtmlToWordConverter : IFileConverter
{
    public FileTypes Source => FileTypes.Html;

    public FileTypes Destination => FileTypes.Word;

    public string Convert(string path)
    {
        return $"{path}->Word";
    }
}

public class WordToPdfConverter : IFileConverter
{
    public FileTypes Source => FileTypes.Word;

    public FileTypes Destination => FileTypes.Pdf;

    public string Convert(string path)
    {
        return $"{path}->Pdf";
    }
}

public class FileConverterModule
{
    private readonly Dictionary<FileTypes, List<IFileConverter>> allConverters = [];

    // Maybe use a builder here
    public void Initialize()
    {
        RegisterConverters([
                new HtmlToMarkdownConverter(),
                new HtmlToWordConverter(),
                new WordToPdfConverter()]);
    }

    private void RegisterConverters(IList<IFileConverter> converters)
    {
        foreach (var converter in converters)
        {
            if (allConverters.ContainsKey(converter.Source))
            {
                allConverters[converter.Source].Add(converter);
            }
            else
            {
                allConverters[converter.Source] = [converter];
            }
        }
    }

    public string ConvertFile(FileTypes source, FileTypes destination, string path)
    {
        ValidateFile(path);

        IList<IFileConverter> converters = GetFileConverters(source, destination);
        string outputFile = path;

        foreach (var converter in converters)
        {
            outputFile = converter.Convert(outputFile);
        }

        return outputFile;
    }

    private List<IFileConverter> GetFileConverters(FileTypes source, FileTypes destination)
    {
        var queue = new Queue<(FileTypes current, List<IFileConverter> path)>();
        var visited = new HashSet<FileTypes>();

        queue.Enqueue((source, new List<IFileConverter>()));
        visited.Add(source);

        while (queue.Count > 0)
        {
            var (currentType, pathSoFar) = queue.Dequeue();

            if (allConverters.TryGetValue(currentType, out var converters))
            {
                foreach (var converter in converters)
                {
                    if (visited.Contains(converter.Destination))
                        continue;

                    var newPath = new List<IFileConverter>(pathSoFar) { converter };

                    if (converter.Destination == destination)
                        return newPath;

                    queue.Enqueue((converter.Destination, newPath));
                    visited.Add(converter.Destination);
                }
            }
        }

        throw new InvalidOperationException($"No conversion path found from {source} to {destination}");
    }

    private static void ValidateFile(string path)
    {
        return;
    }
}
