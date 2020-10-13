using System.Collections.Generic;

namespace WebShop.Domain.Order
{
    public class Order
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Article> Articles { get; set; }
        public BaseAddress ShippingAddress { get; set; }
        public BaseAddress BillingAddress { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }
    }
}
