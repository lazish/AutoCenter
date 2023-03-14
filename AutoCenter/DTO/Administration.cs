using System.ComponentModel.DataAnnotations;

namespace AutoCenter.DTO
{
    public class Administration
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; } = null!;
        public string Education { get; set; } = null!;
    }
}
