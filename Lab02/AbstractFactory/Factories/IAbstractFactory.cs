using AbstractFactory.AbstractProducts;

namespace AbstractFactory.Factories;

public interface IAbstractFactory
{
    public IHeadphones CreateHeadphones(double maxVolume, string formFactor, string[] features);
    public ILaptop CreateLaptop(double diagonal, string os, string ram, string cpu, string gpu);
    public ISmartphone CreateSmartphone(double diagonal, string os, int ram, int storage);
}