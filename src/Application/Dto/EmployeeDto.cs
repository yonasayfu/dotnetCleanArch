namespace Application.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public AddressDto Address { get; set; }
        public ContactDto Contact { get; set; }
    }
}