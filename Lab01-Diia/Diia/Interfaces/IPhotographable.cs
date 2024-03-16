namespace Diia.Interfaces;

public interface IPhotographable 
{
    // document class which implements the Iphotographable class contains a photo
    public void ShowDocumentPhoto();
    public string PhotoURL { get; }
}