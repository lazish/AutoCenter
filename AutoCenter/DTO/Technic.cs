using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Technic
    {
        [Key]
        public int Id { get; set; }
        public string Qualifications { get; set; } = null!;
        public string Experience { get; set; } = null!;
        public ICollection<Car>? Cars { get; set; }
    }
}
