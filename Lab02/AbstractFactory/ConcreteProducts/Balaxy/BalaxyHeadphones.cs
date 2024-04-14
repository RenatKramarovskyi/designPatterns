namespace AbstractFactory.ConcreteProducts.Balaxy;
using AbstractFactory.AbstractProducts;


public class BalaxyHeadphones : IHeadphones
{
    public double MaxVolume { get; set; }
    public string FormFactor { get; set; }
        public string[] Features { get; set; }

        public BalaxyHeadphones(double maxVolume, string formFactor, string[] features)
        {
            MaxVolume = maxVolume;
            FormFactor = formFactor;
            Features = features;
        }
    
    public override string ToString()
    {
        string featuresString = string.Join(", ", Features);
        return $"| Name : Galaxy Buds 2 Pro | Form factor : {this.FormFactor} | Features : {featuresString}";
    }
}