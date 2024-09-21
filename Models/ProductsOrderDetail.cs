namespace BlackbirdStore.Models
{
    public class ProductsOrderDetail
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int OrderDetailsID { get; set; }
        public int ProductID { get; set; }
    }
}