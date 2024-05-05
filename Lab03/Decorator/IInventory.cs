using Decorator.Heroes;

namespace Decorator;

public interface IInventory
{
    IInventory  EquipOn (Hero concreteHero);
    IInventory AddConcreteWeapon();
    IInventory AddConcreteArmor();
}