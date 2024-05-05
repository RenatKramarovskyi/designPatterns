namespace Decorator.Heroes;

public class Warrior : Hero
{
    public Warrior(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with sword!");
        base.Attack();
    }
}