using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Client
    { 
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
