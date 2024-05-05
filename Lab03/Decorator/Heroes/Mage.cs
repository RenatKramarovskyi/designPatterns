namespace Decorator.Heroes;

public class Mage : Hero
{
    public Mage(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a fireball spell!");
        base.Attack();
    }

}