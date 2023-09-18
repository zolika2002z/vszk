namespace vszk.Models
{
    public class SoftwareOSConnect
    {
        [Key]
        [ForeignKey("SoftwareOSConnect")]
        public int SoconnectID { get; set; }
        
        public OS OS { get; set; }       
        
        public Software Software { get; set; } 
    }
}