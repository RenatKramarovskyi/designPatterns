namespace AbstractFactory.AbstractProducts;


public interface ILaptop : IDevice
{
    public double Diagonal { get; set; }
    public string OS { get; set; }
    public string RAM { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }
}