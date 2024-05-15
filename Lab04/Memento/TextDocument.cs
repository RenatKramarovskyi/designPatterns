namespace Memento
{
    public class TextDocument
    {
        private string _content;

        public TextDocument(string content)
        {
            _content = content;
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public MementoTextDocument CreateMemento()
        {
            return new MementoTextDocument(_content);
        }

        public void RestoreFromMemento(MementoTextDocument memento)
        {
            _content = memento.GetSavedContent();
        }

        public override string ToString()
        {
            return _content;
        }
    }
}


