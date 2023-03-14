using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public string LicenseNumber { get; set; } = null!;
        public string LicenseCategory { get; set; } = null!;
    }
}
