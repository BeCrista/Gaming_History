using System.ComponentModel.DataAnnotations;

namespace Console_History.Models
{
    public class Platform
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string? ImagePlatform { get; set; }

        public List<PlatformConsoles> platformConsoles { get; set; }
    }
}
