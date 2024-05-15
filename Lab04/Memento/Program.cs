namespace Memento
{
    using System;
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");
            
            TextDocument initialDocument = new TextDocument("Here is start of the string");
            TextEditor editor = new TextEditor(initialDocument);

            Console.WriteLine("Initial document: " + editor);

            editor.Type(", and now i wanna continue this one. ");
            Console.WriteLine("Document after typing: " + editor);
            
            editor.Type("Another, sentence is here");
            Console.WriteLine("Document after typing: " + editor);

            editor.Undo();
            Console.WriteLine("Document after undo: " + editor);
            editor.Undo();
            Console.WriteLine("Document after undo: " + editor);
        }

    }
}