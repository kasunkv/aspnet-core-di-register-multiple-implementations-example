using MultiImplementationsExample.Web.Models;
using System.Collections.Generic;

namespace MultiImplementationsExample.Web.Services.Contracts
{
    public interface IDiscountProcessor
    {
        (double, List<string>) ProcessDiscount(OrderViewModel order);
    }
}
