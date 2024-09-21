namespace BlackbirdStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Color{ get; set; }
        public enum Status{
            Active,
            Inactive,
            Discontinued
        }
    }
}