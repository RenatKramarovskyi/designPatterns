namespace AbstractFactory.ConcreteProducts.Kiaomi;
using AbstractProducts;

public class KiaomiHeadphones : IHeadphones
{
    public double MaxVolume { get; set; }
    public string FormFactor { get; set; }
    public string[] Features { get; set; }

    public KiaomiHeadphones(double maxVolume, string formFactor, string[] features)
    {
        MaxVolume = maxVolume;
        FormFactor = formFactor;
        Features = features;
    }
    
    public override string ToString()
    {
        string featuresString = string.Join(", ", Features);
        return $"| Name : Redmi Buds 3 Pro Global Ultra Plus Multiply Giga | Form factor : {this.FormFactor} | Features : {featuresString}";
    }
}