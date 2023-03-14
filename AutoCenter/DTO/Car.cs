using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string StateNumber { get; set; } = null!;
        public string RentFee { get; set; } = null!;
        public ICollection<Technic>? ResponsibleEmployee { get; set; }
    }
}
