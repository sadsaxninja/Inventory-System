public class InventoryTransaction
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTime TransactionDate { get; set; }
    public int QuantityChange { get; set; }
}