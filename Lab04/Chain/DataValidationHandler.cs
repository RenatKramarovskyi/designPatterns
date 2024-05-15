namespace Chain;

public class DataValidationHandler : RequestHandler
{
    public override void HandleRequest(OrderRequest request)
    {
        if (string.IsNullOrEmpty(request.ProductName) || request.Quantity <= 0)
        {
            Console.WriteLine("Error: Incorrect order data.");
            return;
        }

        Console.WriteLine("The order data has been verified.");
        Console.WriteLine("Creating an order...");
    }
}