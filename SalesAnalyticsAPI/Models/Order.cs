namespace SalesAnalyticsAPI.Models
{
    public class Order
    {
        public required  int OrderId { get; set; }
        public required  string? ProductId { get; set; }
        public required  Product Product { get; set; }

        public required  string? CustomerId { get; set; }
        public required  Customer Customer { get; set; }

        public required  string? Region { get; set; }
        public required  DateTime DateOfSale { get; set; }
        public required  int QuantitySold { get; set; }
        public required  decimal UnitPrice { get; set; }
        public required  float Discount { get; set; }
        public required  decimal ShippingCost { get; set; }
        public required  string? PaymentMethod { get; set; }
    }
}
