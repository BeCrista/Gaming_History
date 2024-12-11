using System.ComponentModel.DataAnnotations;

namespace Console_History.Models
{
    public class GameAwards
    {
        [Key]
        public int ID { get; set; }

        public string? Description { get; set; }
    }
}
