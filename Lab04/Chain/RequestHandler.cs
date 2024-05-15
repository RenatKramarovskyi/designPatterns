namespace Chain;

public abstract class RequestHandler
{
    protected RequestHandler _nextHandler;

    public RequestHandler SetNextHandler(RequestHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return this;
    }

    public abstract void HandleRequest(OrderRequest request);
}