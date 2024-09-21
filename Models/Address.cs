namespace BlackbirdStore.Models
{
    public class Address
    {
        public int Id{ get; set; }
        public int NumberAddress{ get; set; }
        public string NameAddress{ get; set; }
        public string City{ get; set; }
        public string PostalCode{ get; set; }
        public List<User> Users{ get; set; }
    }
}