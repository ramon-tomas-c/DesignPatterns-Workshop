using System;

namespace FacadePattern
{
    /// <summary>
    /// Subsystems
    /// </summary>
    public class StockService
    {
        public void CheckStock()
        {
            Console.WriteLine("Product available in Stock");
        }
    }

    public class BasketService
    {
        public void ClearBasket()
        {
            Console.WriteLine("Order cleared from basket");
        }
    }

    public class PaymentService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment is completed");
        }
    }

    public class OrderService
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Order is created and pending to be processed.");
        }
    }
}
