namespace UserProvider.Business.Models;

public class Order
{
    public string OrderNumber { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; } = DateTime.MinValue;
    public string Status { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
}
