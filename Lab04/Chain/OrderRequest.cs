namespace Chain;

public class OrderRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}
