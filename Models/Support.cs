namespace vszk.Models
{
    public class Support
    {
        [Key]
        [ForeignKey("Support")]
        public int supportID { get; set; }
        
        [Required]
        public Language Language { get; set; }       
        
        [Required]
        public Software Software { get; set; } 
        
    }
}