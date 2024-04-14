namespace Builder;

public class EnemyUnit : IUnit
{


    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Height
    {
        get => _height;
        set => _height = value;
    }

    public string Stature
    {
        get => _stature;
        set => _stature = value ?? throw new ArgumentNullException(nameof(value));
    }
    

    public string Specialization
    {
        get => _specialization;
        set => _specialization = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string BadAction
    {
        get => _badAction;
        set => _badAction = value ?? throw new ArgumentNullException(nameof(value));
    }
    

    private string _warside = "Dark side";
    private string _name = "No name";
    private int _height;
    private string _stature;
    private string _specialization;
    private string _badAction;
    
    public void ShowUnitInfo()
    {
        Console.WriteLine("\n===================");
        Console.WriteLine($"Unit's name : {this._name}");
        Console.WriteLine($"Height : {this._height} cm");
        Console.WriteLine($"Stature : {this._stature}");
        Console.WriteLine($"Specialization : {this._specialization}");
        Console.WriteLine($"Bad action : {this._badAction}");
        Console.WriteLine("=================== \n");
    }

}