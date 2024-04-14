namespace Builder;

public interface IUnitBuilder
{
    IUnitBuilder SetUnitName(string name);
    IUnitBuilder SetUnitHeight(int height);
    IUnitBuilder SetUnitStature(string stature);
    IUnitBuilder SetUnitSpecialization(string specialization);
    IUnitBuilder SetAction(string action);
        
    IUnit GetTotalUnit();
}
