using Diia.Interfaces;

namespace Diia;

public class Document 
{
    public void DocumentAction(IDocumentAction document)
    {
        if (document != null)
        {
            document.DoAction();
        }
    }
}