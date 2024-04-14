namespace Builder;

public class EnemyBuilder : IUnitBuilder
{
    private EnemyUnit _enemyUnit = new EnemyUnit();
    private void _reset()
    {
        this._enemyUnit = new EnemyUnit();
    }
    public IUnit GetTotalUnit()
    {
        EnemyUnit heroUnit = this._enemyUnit;
        this._reset();
        return heroUnit;
    }
    
    public IUnitBuilder SetUnitName(string name)
    {
        this._enemyUnit.Name = name;
        return this;
    }

    public IUnitBuilder SetUnitHeight(int height)
    {
        this._enemyUnit.Height = height;
        return this;
    }

    public IUnitBuilder SetUnitStature(string stature)
    {
        this._enemyUnit.Stature = stature;
        return this;
    }
    

    public IUnitBuilder SetUnitSpecialization(string spec)
    {
        this._enemyUnit.Specialization = spec;
        return this;
    }

    public IUnitBuilder SetAction(string goodAction)
    {
        this._enemyUnit.BadAction = goodAction;
        return this;
    }
}