namespace AbstractFactory.ConcreteProducts.Kiaomi;
using AbstractProducts;

public class KiaomiLaptop : ILaptop
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public string RAM { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }


    public KiaomiLaptop(double diagonal, string os, string ram, string cpu, string gpu)
    {
        Diagonal = diagonal;
        OS = os;
        RAM = ram;
        CPU = cpu;
        GPU = gpu;
    }
    
    public override string ToString()
    {
        return $"| Name : Redmi book | OS : {this.OS} | RAM : {this.RAM} | CPU : {this.CPU} | GPU : {this.GPU}";
    }
}