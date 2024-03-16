using Diia.Interfaces;

namespace Diia.Documents;

public class MilitaryLicense: IDocument, IQRcodeable, IDocumentAction
{
    public void ShowPersonInfo()
    {
        Console.WriteLine($"First name : {PersonInfo.FirstName}");
        Console.WriteLine($"Last name : {PersonInfo.LastName}");
        Console.WriteLine($"Sex : {PersonInfo.Sex}");
        Console.WriteLine($"Birth day : {PersonInfo.BirthDay.ToShortDateString()}");
    }
    
    public PersonInfo PersonInfo { get; }
    public string Series { get; }
    public int Number { get; }
    public DateTime IssueDate { get; }
    
    public MilitaryLicense(PersonInfo personInfo, DateTime issueDate, string series, int number)
    {
        this.PersonInfo = personInfo;
        this.IssueDate = issueDate;
        this.Series = series;
        this.Number = number;
    }
    public void ShowDocumentName()
    {
        Console.WriteLine($"Document title : Military license (id)");
    }

    public void ShowDocumentIssueDate()
    {
        Console.WriteLine($"Date of issue : {IssueDate.ToShortDateString()}"); 
    }
    
    public void GenerateQRcode()
    {
        Console.WriteLine("\nHere is QRcode : ':)' ");
    }

    public void DoAction()
    {
        this.ShowDocumentName();
        this.ShowPersonInfo();
        this.GenerateQRcode();
    }
}