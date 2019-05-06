using MultiImplementationsExample.Web.Models;
using MultiImplementationsExample.Web.Services.Contracts;

namespace MultiImplementationsExample.Web.Services
{
    public class SeasonalDiscount : IDiscount
    {
        public string Description => "Christmas discount of 5%";

        public double CalculateDiscount(OrderViewModel order)
        {
            return (order.Price * order.Quantity) * 0.05;
        }
    }
}
