using System.ComponentModel.DataAnnotations;

namespace Console_History.Models
{
    public class SliderGames
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? NameGame { get; set; }
        [Required]
        public string? ImageGame { get; set; }
        [Required]
        public string? GameConsole { get; set; }
    }
}
