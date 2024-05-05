using Decorator.Heroes;

namespace Decorator;

public abstract class InventoryUnitDecorator : IInventory
{
    protected IInventory _inventory;

    public InventoryUnitDecorator(IInventory inventory)
    {
        _inventory = inventory;
    }

    public virtual IInventory AddConcreteWeapon()
    {
        _inventory = new ConcreteWeapon(_inventory);
        return this;
    }

    public virtual IInventory AddConcreteArmor()
    {
        _inventory = new ConcreteArmor(_inventory);
        return this;
    }

    public virtual IInventory EquipOn(Hero hero)
    {
        if (_inventory != null)
        {
            return _inventory.EquipOn(hero);
        }
        return this;
    }
}
