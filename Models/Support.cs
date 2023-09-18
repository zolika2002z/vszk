namespace vszk.Models
{
    public class Support
    {
        [Key]
        [ForeignKey("Support")]
        public int supportID { get; set; }
        
        public Language Language { get; set; }       
        
        public Software Software { get; set; } 
        
    }
}