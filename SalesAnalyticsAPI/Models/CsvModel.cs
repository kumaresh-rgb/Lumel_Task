
namespace SalesAnalyticsAPI.Models
{
    public class CsvModel
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Category { get; set; } = null!;

        public string CustomerId { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;

        public string Region { get; set; } = null!;
        public DateTime DateOfSale { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public decimal ShippingCost { get; set; }
        public string PaymentMethod { get; set; } = null!;
    }
}