using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace NinjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ninjectKernel=new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();//绑定到LinValueCalculator的实例中
            //应为LinqValueCalculator的实例是依赖DefaultDiscountor的,因此要绑定到DefaultDiscountHelper的实例中
            ninjectKernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithConstructorArgument("discountParam", 40M);

            var calcImpl = ninjectKernel.Get<IValueCalculator>();
            var cart=new ShoppingCart(calcImpl);
            Console.WriteLine("Total :{0:c}",cart.CalculateStockValue());
        }
    }
}
