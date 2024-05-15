namespace Chain;

public class OrderHandler
{
    public void ProcessOrderRequest(OrderRequest request)
    {
        var authenticationHandler = new AuthenticationHandler();
        var adminRightsHandler = new AdminRightsHandler();
        var dataValidationHandler = new DataValidationHandler();
    
        Console.WriteLine(new string('=', 50));
        authenticationHandler.SetNextHandler(adminRightsHandler);
        adminRightsHandler.SetNextHandler(dataValidationHandler);

        authenticationHandler.HandleRequest(request);
        Console.WriteLine(new string('=', 50));

    }
}