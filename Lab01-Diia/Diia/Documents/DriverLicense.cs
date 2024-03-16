using Diia.Interfaces;

namespace Diia.Documents;

public class DriverLicense : IDocument, IPhotographable, IQRcodeable, IDocumentAction
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
    public string PhotoURL { get; }

    
    public DriverLicense(PersonInfo personInfo, DateTime issueDate, string series, int number, string photoUrl)
    {
        this.PersonInfo = personInfo;
        this.IssueDate = issueDate;
        this.Series = series;
        this.Number = number;
        this.PhotoURL = photoUrl;
    }
    public void ShowDocumentName()
    {
        Console.WriteLine($"Document title : Driver license");
    }
    
    public void ShowDocumentIssueDate()
    {
        Console.WriteLine($"Date of issue : {IssueDate.ToShortDateString()}"); 
    }
    
    public void ShowDocumentPhoto()
    {
        Console.WriteLine($"Document photo : {this.PhotoURL}");
    }

    public void GenerateQRcode()
    {
        Console.WriteLine("\nHere is QRcode : ':)' ");
    }

    public void DoAction()
    {
        this.ShowDocumentName();
        this.ShowDocumentPhoto();
        this.ShowPersonInfo();
        this.GenerateQRcode();
    }
}