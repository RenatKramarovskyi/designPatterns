namespace Builder;

public class HeroBuilder : IUnitBuilder
{
    private HeroUnit _heroUnit = new HeroUnit();
    private void _reset()
    {
        this._heroUnit = new HeroUnit();
    }
    public IUnit GetTotalUnit()
    {
        HeroUnit heroUnit = this._heroUnit;
        this._reset();
        return heroUnit;
    }
    
    public IUnitBuilder SetUnitName(string name)
    {
        this._heroUnit.Name = name;
        return this;
    }

    public IUnitBuilder SetUnitHeight(int height)
    {
        this._heroUnit.Height = height;
        return this;
    }

    public IUnitBuilder SetUnitStature(string stature)
    {
        this._heroUnit.Stature = stature;
        return this;
    }
    

    public IUnitBuilder SetUnitSpecialization(string spec)
    {
        this._heroUnit.Specialization = spec;
        return this;
    }

    public IUnitBuilder SetAction(string goodAction)
    {
        this._heroUnit.GoodAction = goodAction;
        return this;
    }
}