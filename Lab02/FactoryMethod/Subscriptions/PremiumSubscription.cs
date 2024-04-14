namespace FactoryMethod.Subscriptions;

public class PremiumSubscription : ISubscription
{
    private double price = 10.99;
    
    public void ChangePrice () {}
    
    public void PrintInfo()
    {
        Console.WriteLine($"| Title : Premium Subscription | Monthly fee : {this.price} |");
    }

    public override string ToString()
    {
        return $"Premium Subscription";
    }
}