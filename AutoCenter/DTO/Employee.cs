using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public ICollection<Driver>? Drivers { get; set; }
        public ICollection<Technic>? Technics { get; set; }
        public ICollection<Administration>? Administrations { get; set; }
    }
}
