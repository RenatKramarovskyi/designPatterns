namespace FactoryMethod.Subscriptions;

public class EducationalSubscription : ISubscription
{
    public double price = 4.99;
    
    public void ChangePrice () {}
    
    public void PrintInfo()
    {
       Console.WriteLine($"| Title : Educational Subscription | Monthly fee : {this.price} |");
    }

    public override string ToString()
    {
        return $"Educational Subscription";
    }
}