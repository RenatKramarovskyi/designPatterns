namespace Diia.Interfaces;

public interface IDocument
{
    void ShowDocumentName();
    void ShowDocumentIssueDate();
    void ShowPersonInfo();

    public PersonInfo PersonInfo { get;}
    public string Series { get; }
    public int Number { get; }
    public DateTime IssueDate { get; }

}