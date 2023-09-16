using System.ComponentModel.DataAnnotations;

namespace vszk.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        
        public DateTime Datumido { get; set; }
        
        [Required]
        public User User { get; set; }
        
        [Required]
        public Software Software { get; set; }
        
        [Required]
        public Star Star { get; set; }
        
        [Required]
        public TextRating TextRating { get; set; }
    }
}