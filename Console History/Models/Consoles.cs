using System.ComponentModel.DataAnnotations;

namespace Console_History.Models
{
    public class Consoles
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? NameConsole { get; set; }
        [Required]
        public string? ImageConsole { get; set; }
        [Required]
        public string? DescriptionConsole { get; set; }

        public List<PlatformConsoles> platformConsoles { get; set; }
    }
}
