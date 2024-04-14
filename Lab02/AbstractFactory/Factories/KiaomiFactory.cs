using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts.Kiaomi;
namespace AbstractFactory.Factories;

public class KiaomiFactory : IAbstractFactory
{
    public IHeadphones CreateHeadphones(double maxVolume, string formFactor, string[] features)
    {
        return new KiaomiHeadphones(maxVolume, formFactor, features);
    }

    public ILaptop CreateLaptop(double diagonal, string os, string ram, string cpu, string gpu)
    {
       return new KiaomiLaptop(diagonal, os, ram, cpu, gpu);
    }

    public ISmartphone CreateSmartphone(double diagonal, string os, int ram, int storage)
    {
       return new KiaomiSmartphone(diagonal, os, ram, storage);
    }
}