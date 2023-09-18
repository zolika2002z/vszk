namespace vszk.Models
{
    public class SoftwareLangConnect
    {
        [Key]
        [ForeignKey("SoftwareLangConnect")]
        public int SlconnectID { get; set; }
        
        [Required]
        public Language Language { get; set; }       
        
        [Required]
        public Software Software { get; set; } 
    }
}