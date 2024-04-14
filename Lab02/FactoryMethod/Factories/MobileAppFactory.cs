using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories;

public class MobileAppFactory : IPlatformFactory
{
    public ISubscription CreateSubscription(string subscriptionType)
    {
        Console.WriteLine("Purchased from mobile app");
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