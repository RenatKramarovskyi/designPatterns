using Diia.Interfaces;

namespace Diia;

public class Container
{
    private IDocumentAction[] _documents;
    
    public Container(IDocumentAction[] documents)
    {
        _documents = documents;
    }
    public void leftShiftDocuments()
    {
        Console.WriteLine("Documents was shifted to left");
    }
    public void rightShiftDocuments()
    {
        Console.WriteLine("Documents was shifted to right");
    }
    public void sortDocuments()
    {
        Console.WriteLine("sorted by 1 param");
    }
 
    public void showAllDocumentsInfo()
    {
        foreach (var doc in this._documents)
        {
            Console.WriteLine("====================");
            Console.WriteLine("====================");
            doc.DoAction();
            Console.WriteLine("===================\n\n");

        }
    }
}