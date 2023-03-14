using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Client>? Clients { get; set; }
        public ICollection<Car>? Cars { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan RentalDuration { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
