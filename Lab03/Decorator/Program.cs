namespace Decorator
{
    using Heroes;

    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            Hero warrior = new Warrior("Lloyd", 100);
            var warriorEquippedInventory1 = new ConcreteWeapon(null)
                .AddConcreteArmor()
                .EquipOn(warrior);
            warrior.EquipInventory(warriorEquippedInventory1);

            Hero mage = new Mage("Tempest", 80);
            var mageEquippedInventory = new ConcreteWeapon(null)
                .EquipOn(mage);
            mage.EquipInventory(mageEquippedInventory);

            Hero palladin = new Palladin("Arthur", 120);
            var palladinEquippedInventory = new ConcreteArmor(null)
                .EquipOn(palladin);
            palladin.EquipInventory(palladinEquippedInventory);


        }
    }
}