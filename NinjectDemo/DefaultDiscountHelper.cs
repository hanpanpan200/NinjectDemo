using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectDemo
{
    public class DefaultDiscountHelper:IDiscountHelper
    {
        public decimal DiscountRate { get; set; }

        public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountRate = discountParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
           return (DiscountRate/100m*totalParam);
        }
    }
}
