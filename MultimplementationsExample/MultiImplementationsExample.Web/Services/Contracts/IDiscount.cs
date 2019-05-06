using MultiImplementationsExample.Web.Models;

namespace MultiImplementationsExample.Web.Services.Contracts
{
    public interface IDiscount
    {
        string Description { get; }
        double CalculateDiscount(OrderViewModel order);
    }
}
