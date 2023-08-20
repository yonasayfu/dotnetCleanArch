namespace Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address  Address { get; set; }
        public Contact  Contact { get; set; }


    }
}