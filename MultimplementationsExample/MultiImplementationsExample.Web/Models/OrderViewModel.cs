using System.ComponentModel.DataAnnotations;

namespace MultiImplementationsExample.Web.Models
{
    public class OrderViewModel
    {
        [Display(Name = "Item")]
        public string ItemName { get; set; }
        [Display(Name = "Price ($)")]
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
