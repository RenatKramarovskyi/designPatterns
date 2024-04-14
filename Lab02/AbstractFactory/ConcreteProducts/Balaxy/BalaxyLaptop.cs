using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.Balaxy;

public class BalaxyLaptop : ILaptop
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public string RAM { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }

    public BalaxyLaptop(double diagonal, string os, string ram, string cpu, string gpu)
    {
        Diagonal = diagonal;
        OS = os;
        RAM = ram;
        CPU = cpu;
        GPU = gpu;
    }
    
    public override string ToString()
    {
        return $"| Name : Galaxy Book | OS : {this.OS} | RAM : {this.RAM} | CPU : {this.CPU} | GPU : {this.GPU}";
    }
}