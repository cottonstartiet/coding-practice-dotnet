
namespace coding_practice_dotnet
{
    internal class EventProcessor
    {
        private const int MAX_SAVE_TIME_DIFF = 5;
        private const int DB_BATCH_SIZE = 500;
        private readonly List<string> messages = [];
        private DateTime lastSaveTime = DateTime.Now;
        private readonly object messagesLock = new();

        public void ProcessMessages(List<string> message)
        {
            lock (messagesLock)
            {
                messages.AddRange(message);
                if (messages.Count >= DB_BATCH_SIZE)
                {
                    SaveToDbAndResetTime();
                }
            }
        }

        public void OnTick()
        {
            if (DateTime.Now.Subtract(lastSaveTime).Seconds > MAX_SAVE_TIME_DIFF)
            {
                SaveToDbAndResetTime();
            }
        }

        private void SaveToDbAndResetTime()
        {
            // Save messages to DB here in a thread safe way
            lock (messagesLock)
            {
                messages.Clear();
                lastSaveTime = DateTime.Now;
            }
        }
    }
}
