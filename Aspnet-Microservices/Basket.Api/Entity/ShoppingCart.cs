using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Api.Entity
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
        public List<ShoppingCartItem> ShoppingItems { get; set; } = new();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach(var item in ShoppingItems)
                {
                    totalPrice += totalPrice + item.Quantity * item.Price;
                }
                return totalPrice;
            }
        }
    }
}
