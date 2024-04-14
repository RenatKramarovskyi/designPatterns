namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 3");
        
        Authenticator inst1 = Authenticator.CreateInstance();
        Console.WriteLine($"Instance 1 hashcode : {inst1.GetHashCode()}");
        
        Authenticator inst2 = Authenticator.CreateInstance();
        Console.WriteLine($"Instance 2 hashcode : {inst2.GetHashCode()}");
        
        Console.WriteLine($"Is equal : {object.ReferenceEquals(inst1, inst2)}");

        
    }
}