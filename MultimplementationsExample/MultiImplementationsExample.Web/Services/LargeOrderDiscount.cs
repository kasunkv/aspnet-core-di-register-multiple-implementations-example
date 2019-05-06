using MultiImplementationsExample.Web.Models;
using MultiImplementationsExample.Web.Services.Contracts;

namespace MultiImplementationsExample.Web.Services
{
    public class LargeOrderDiscount : IDiscount
    {
        public string Description => "Orders over $1000 gets 4% discount";

        public double CalculateDiscount(OrderViewModel order)
        {
            var totalBill = order.Price * order.Quantity;

            if (totalBill > 1000.0)
            {
                return totalBill * 0.04;
            }

            return 0;
        }
    }
}
