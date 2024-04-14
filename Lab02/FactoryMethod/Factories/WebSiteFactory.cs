using FactoryMethod.Subscriptions;
namespace FactoryMethod.Factories;

public class WebSiteFactory : IPlatformFactory
{
    public ISubscription CreateSubscription(string subscriptionType)
    {
        Console.WriteLine("Purchased from web site");
        switch (subscriptionType.ToLower())
        {
            case "domestic" :
                return new DomesticSubscription();
            case "educational" :
                return new EducationalSubscription();
            case "premium" :
                return new PremiumSubscription();
            default:
                throw new Exception("This type of subscription does not exist");
        }
    }
}