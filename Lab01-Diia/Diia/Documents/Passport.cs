using Diia.Interfaces;

namespace Diia;

public class Passport : IDocument, IPhotographable, IQRcodeable, IDocumentAction
{
    public void ShowPersonInfo()
    {
        Console.WriteLine($"First name : {PersonInfo.FirstName}");
        Console.WriteLine($"Last name : {PersonInfo.LastName}");
        Console.WriteLine($"Sex : {PersonInfo.Sex}");
        Console.WriteLine($"Birth day : {PersonInfo.BirthDay.ToShortDateString()}");
    }

    public PersonInfo PersonInfo { get; private set; }
    public DateTime IssueDate { get; private set; }
    public string Series { get; private set; }
    public int Number { get; private set; }
    

    public string PhotoURL { get; private set; }

    
    public Passport(PersonInfo personInfo, DateTime issueDate, string series, int number, string photoUrl)
    {
        this.PersonInfo = personInfo;
        this.IssueDate = issueDate;
        this.Series = series;
        this.Number = number;
        this.PhotoURL = photoUrl;
    }
    
    public void ShowDocumentName()
    {
        Console.WriteLine($"Document title : Ukrainian passport");
    }

    public void ShowDocumentPhoto()
    {
        Console.WriteLine($"Document photo : {this.PhotoURL}");
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
        this.ShowDocumentPhoto();
        this.ShowPersonInfo();
        this.GenerateQRcode();
    }
}