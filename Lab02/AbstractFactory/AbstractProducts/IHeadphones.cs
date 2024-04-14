namespace AbstractFactory.AbstractProducts;

public interface IHeadphones : IDevice
{
    public double MaxVolume { get; set; }
    public string FormFactor { get; set; }
    public string[] Features { get; set; }
}