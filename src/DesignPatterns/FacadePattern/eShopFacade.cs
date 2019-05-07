using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// The Facade class provides a simple interface to the complex 
    /// business logic
    /// </summary>
    public class eShopFacade
    {
        private readonly BasketService _basketService;
        private readonly StockService _stockService;
        private readonly PaymentService _paymentService;
        private readonly OrderService _orderService;

        public eShopFacade(
            BasketService basketService, 
            StockService stockService, 
            PaymentService paymentService,
            OrderService orderService)
        {
            _basketService = basketService;
            _stockService = stockService;
            _paymentService = paymentService;
            _orderService = orderService;
        }

        /// <summary>
        /// Facade method that simplifies a business process that involves 
        /// many subsystems to be completed.
        /// </summary>
        public void CreateOrder()
        {
            _stockService.CheckStock();
            _paymentService.ProcessPayment();
            _orderService.PlaceOrder();
            _basketService.ClearBasket();
        }
    }
}
