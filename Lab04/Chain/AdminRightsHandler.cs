namespace Chain;

public class AdminRightsHandler : RequestHandler
{
    public override void HandleRequest(OrderRequest request)
    {
        if (request.IsAdmin)
        {
            Console.WriteLine("User has administrator rights.");
            _nextHandler?.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("The user doesnt have administrator rights.");
        }
    }
}