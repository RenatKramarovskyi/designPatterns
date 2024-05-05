namespace Decorator.Heroes;

public abstract class Hero 
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    public List<IInventory> Inventories { get; private set; } = new List<IInventory>();

    public Hero(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void EquipInventory(IInventory inventory)
    {
        Inventories.Add(inventory);
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks!");

        foreach (var inventory in Inventories)
        {
            inventory.EquipOn(this);
        }
    }
}