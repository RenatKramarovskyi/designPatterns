using System;

namespace Observer
{
    public class ImgFromLocalStrategy : IImageLoadingStrategy
    {
        public void UploadImage(string href)
        {
            Console.WriteLine($" ===== Loading image from file system: {href} successfully ===== ");
            //upload logic
        }
    }
}