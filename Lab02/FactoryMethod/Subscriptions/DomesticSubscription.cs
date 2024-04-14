namespace FactoryMethod.Subscriptions;

public class DomesticSubscription : ISubscription
{

    private double price = 2.99;
    
    public void ChangePrice () {}
    
    public void PrintInfo()
    {
        Console.WriteLine($"| Title : Domestic Subscription | Monthly fee : {this.price} |");
    }

    public override string ToString()
    {
        return $"Domestic Subscription";
    }
}