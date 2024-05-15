namespace Observer;

public class ImgFromNetworkStrategy : IImageLoadingStrategy
{
    public void UploadImage(string href)
    {
        Console.WriteLine($" ===== Loading image from network: {href} successfully ===== ");
        //upload logic
    }
}