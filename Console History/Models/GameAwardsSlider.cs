using System.ComponentModel.DataAnnotations;

namespace Console_History.Models
{
    public class GameAwardsSlider
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? NameGOTY { get; set; }
        [Required]
        public string? PublisherGOTY { get; set; }
        [Required]
        public string? ImageGOTY { get; set; }
        [Required]
        public string? DescriptionGOTY { get; set; }
    }
}
