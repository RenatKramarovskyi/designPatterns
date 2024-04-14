using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories;

public interface IPlatformFactory
{
    ISubscription CreateSubscription(string subscriptionType);
}