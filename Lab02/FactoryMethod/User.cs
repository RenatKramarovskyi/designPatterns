using System;
using System.Globalization;
using FactoryMethod.Factories;
using FactoryMethod.Subscriptions;

namespace FactoryMethod;

public class User
{
    public string Username { get; private set; }
    private string _id;
    private IPlatformFactory _platform;
    private ISubscription _subscriptions;

    public User(string username, IPlatformFactory platform)
    {
        this.Username = username;
        this._id = System.Guid.NewGuid().ToString();
        this._platform = platform;
    }

    public void GetSubscription(string subscriptionType){
        
        this._subscriptions = this._platform.CreateSubscription(subscriptionType);
    }
    
    
    public override string ToString()
    {
        return $"| Username : {this.Username} | Id : {this._id} | Subscription type : {this._subscriptions} |";
    }
}