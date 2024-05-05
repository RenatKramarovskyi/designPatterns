namespace Decorator.Heroes;

public class Palladin : Hero
{
    public Palladin(string name, int health) : base(name, health)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with holy light and shield!");
        base.Attack();
    }
}