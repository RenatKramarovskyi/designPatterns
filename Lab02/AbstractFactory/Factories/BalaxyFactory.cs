using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts.Balaxy;

namespace AbstractFactory.Factories;

public class BalaxyFactory : IAbstractFactory
{
    public IHeadphones CreateHeadphones(double maxVolume, string formFactor, string[] features)
    {
        return new BalaxyHeadphones(maxVolume, formFactor, features);
    }

    public ILaptop CreateLaptop(double diagonal, string os, string ram, string cpu, string gpu)
    {
        return new BalaxyLaptop(diagonal, os, ram, cpu, gpu);
    }

    public ISmartphone CreateSmartphone(double diagonal, string os, int ram, int storage)
    {
        return new BalaxySmartphone(diagonal, os, ram, storage);
    }
}