namespace AbstractFactory.ConcreteProducts.Kiaomi;
using AbstractProducts;

public class KiaomiSmartphone : ISmartphone
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
    
    public KiaomiSmartphone(double diagonal, string os, int ram, int storage)
    {
        Diagonal = diagonal;
        OS = os;
        RAM = ram;
        Storage = storage;
    }
    
    public override string ToString()
    {
        return $"| Name : Redmi Note 9 pro | OS : {this.OS} | RAM : {this.RAM} | Storage size : {this.Storage} |";
    }
}