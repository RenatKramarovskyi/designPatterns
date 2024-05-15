namespace Chain;

public class AuthenticationHandler : RequestHandler
{
    private readonly string _validUsername = "testusername";
    private readonly string _validPassword = "password123";

    public override void HandleRequest(OrderRequest request)
    {
        if (IsValidUser(request.Username, request.Password))
        {
            Console.WriteLine("User is authorized.");
            _nextHandler?.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("Error: incorrect authorization data.");
        }
    }

    private bool IsValidUser(string username, string password)
    {
        return username == _validUsername && password == _validPassword;
    }
}
