namespace AbstractFactory.AbstractProducts;


public interface ISmartphone : IDevice
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
}