using Decorator.Heroes;

namespace Decorator;

public class ConcreteWeapon : InventoryUnitDecorator
{
    public ConcreteWeapon(IInventory inventory) : base(inventory)
    {
    }

    public override IInventory EquipOn(Hero hero)
    {
        Console.WriteLine($"{hero.Name} equips a weapon.");
        return base.EquipOn(hero);
    }
}