namespace BlackbirdStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime ShippingAddress { get; set; }
        public Decimal TotalAmount { get; set; }
        public enum OrderStatus{
            Pending,
            Processing,
            Shipped,
            Delivered,
            Canceled
        } 
        public List<User> Users { get; set; }


        // Connection with entity OrderDetail
        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}