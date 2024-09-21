namespace BlackbirdStore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastFirstName { get; set; }
        public string LastSecondName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        // Connection with entity Address
        public int AddressId { get; set; }
        public Address Address { get; set; }

        // Connection with entity Order
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}