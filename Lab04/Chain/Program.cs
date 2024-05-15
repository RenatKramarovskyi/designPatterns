namespace Chain
{
    using System;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var orderRequest = new OrderRequest
            {
                Username = "testusername",
                Password = "password123",
                IsAdmin = false,
                ProductName = "Canon 3200D",
                Quantity = 2
            };
            
            var orderRequest2 = new OrderRequest
            {
                Username = "testusername",
                Password = "password123",
                IsAdmin = true,
                ProductName = "Canon 3200D",
                Quantity = 2
            };

            var orderHandler = new OrderHandler();
            orderHandler.ProcessOrderRequest(orderRequest);
            orderHandler.ProcessOrderRequest(orderRequest2);
        }
    }
}