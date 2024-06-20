namespace coding_practice_dotnet
{
    internal static class Logger
    {
        internal static void Log(string message) => System.Console.WriteLine(message);

        internal static void Log(IList<object> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
