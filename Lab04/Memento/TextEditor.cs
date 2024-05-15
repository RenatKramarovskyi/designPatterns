namespace Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<MementoTextDocument> _history = new Stack<MementoTextDocument>(); // why stack ? actualy its simple to explain
        
        //bcause the stack allows to easily and efficiently perform operations of saving and restoring the state of the object.
        // like LIFO stuff, If we save an object for further updating,
        // the most current new state\version will always be available for updating first

        public TextEditor(TextDocument document)
        {
            _document = document;
            Save();
        }

        public void Type(string text)
        {
            _document.Content += text;
            Save();
        }

        public void Undo()
        {
            if (_history.Count > 1)
            {
                _history.Pop(); 
                _document.RestoreFromMemento(_history.Peek()); 
                Console.WriteLine("CTRL + Z");
            }
        }

        public override string ToString()
        {
            return _document.ToString();
        }

        private void Save()
        {
            MementoTextDocument memento = _document.CreateMemento();
            _history.Push(memento);
        }
    }

}
