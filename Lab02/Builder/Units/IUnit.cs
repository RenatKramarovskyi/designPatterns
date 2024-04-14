namespace Builder;

public interface IUnit
{
    public string Name { get;  }
    public int Height { get; }
    public string Stature { get; }
    public string Specialization { get; }
    public void ShowUnitInfo();
}