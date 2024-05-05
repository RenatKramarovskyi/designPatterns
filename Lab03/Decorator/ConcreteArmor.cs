using Decorator.Heroes;

namespace Decorator;

public class ConcreteArmor : InventoryUnitDecorator
{
    public ConcreteArmor(IInventory inventory) : base(inventory)
    {
    }

    public override IInventory EquipOn(Hero hero)
    {
        Console.WriteLine($"{hero.Name} equips armor.");
        return base.EquipOn(hero);
    }
}