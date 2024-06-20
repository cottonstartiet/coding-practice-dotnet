namespace coding_practice_dotnet
{
    internal static class Logger
    {
        internal static void Log(string message) => Console.WriteLine(message);

        internal static void Log(int value) => Console.WriteLine(value);

        internal static void Log(IEnumerable<object> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
