using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.Balaxy;

public class BalaxySmartphone : ISmartphone
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }

    public BalaxySmartphone(double diagonal, string os, int ram, int storage)
    {
        Diagonal = diagonal;
        OS = os;
        RAM = ram;
        Storage = storage;
    }

    public override string ToString()
    {
        return $"| Name : Galaxy S8 | OS : {this.OS} | RAM : {this.RAM} | Storage size : {this.Storage} |";
    }
}