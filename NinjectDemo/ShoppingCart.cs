using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectDemo
{
    public class ShoppingCart
    {
        private IValueCalculator calculator;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calculator = calcParam;
        }
        public decimal CalculateStockValue()
        {
            Product[] products =
            {
                new Product(){Name = "book",Price = 80M}, 
                new Product(){Name = "book",Price = 80M}, 
                new Product(){Name = "book",Price = 80M}, 
                new Product(){Name = "book",Price = 80M}, 
            };
            decimal totalValue = calculator.ValueProducts(products);
            return totalValue;
        }
    }
}
