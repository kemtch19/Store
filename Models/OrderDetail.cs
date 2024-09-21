namespace BlackbirdStore.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public DateOnly OrderDate { get; set; }
        public enum PaymentMethod{
            CreditCard,
            SavingCard,
            Cash
        }
        public int OrderId { get; set; }
        public Order Orders { get; set; }
    }
}