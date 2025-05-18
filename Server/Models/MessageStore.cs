namespace Server.Models
{
    public class MessageStore
    {
        private readonly List<(string User, string Message)> _messages = [];

        public IReadOnlyList<(string User, string Message)> Messages => _messages.AsReadOnly();

        public void AddMessage(string user, string message)
        {
            _messages.Add((user, message));
        }
    }
}
