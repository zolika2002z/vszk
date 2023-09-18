namespace vszk.Models
{
    public class SoftwareLangConnect
    {
        [Key]
        [ForeignKey("SoftwareLangConnect")]
        public int SlconnectID { get; set; }
        
        public Language Language { get; set; }       
        
        public Software Software { get; set; } 
    }
}