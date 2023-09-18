namespace vszk.Models
{
    public class Rating
    {
        [Key]
        [ForeignKey("Rating")]
        public int RatingID { get; set; }
        
        public DateTime Datumido
        {
            get {return DateTime.Now;}
        }
        
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