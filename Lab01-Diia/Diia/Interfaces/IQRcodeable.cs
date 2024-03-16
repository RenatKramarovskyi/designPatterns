namespace Diia.Interfaces;

public interface IQRcodeable
{
    // document class which implements the IQRcodeable can generate QRcode as in Diia after licking on the document in app
    public void GenerateQRcode();
}