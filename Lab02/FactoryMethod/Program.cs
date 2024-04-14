using System;
using FactoryMethod.Factories;

namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        User[] users = new[]
        {
            new User("Kongroo", new WebSiteFactory()),
            new User("Renatik", new MobileAppFactory()),
            new User("Capdelbka", new ManagerCallFactory())
        };


        users[0].GetSubscription("Premium");
        users[1].GetSubscription("Educational");
        users[2].GetSubscription("Domestic");

        foreach (var user in users)
        {
            Console.WriteLine(user.ToString());
        }
    }
}

