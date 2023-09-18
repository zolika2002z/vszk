namespace vszk.Models
{
    public class SoftwareCompConnect
    {
        [Key]
        [ForeignKey("SoftwareCompConnect")]
        public int ScconnectID { get; set; }
        
        public Compatibility Compatibility { get; set; }       
        
        public Software Software { get; set; }    
    }
}