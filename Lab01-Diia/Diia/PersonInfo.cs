using System.Runtime.InteropServices.JavaScript;

namespace Diia;

public class PersonInfo
{
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool Sex
    {
        get => _sex;
        set => _sex = value;
    }

    public DateTime BirthDay
    {
        get => _birthDay;
        set => _birthDay = value;
    }

    private string _firstName;
    private string _lastName;
    private bool _sex;
    private DateTime _birthDay;

    public PersonInfo(string firstName, string lastName, bool sex, DateTime birthDay)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._sex = sex;
        this._birthDay = birthDay;
    } 
}