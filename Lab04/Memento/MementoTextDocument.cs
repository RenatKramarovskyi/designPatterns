namespace Memento
{
    public class MementoTextDocument : IMemento
    { 
        private readonly string _savedContent;

        public MementoTextDocument(string content)
        {
            _savedContent = content;
        }

        public string GetSavedContent()
        {
            return _savedContent;
        }
    }
}

