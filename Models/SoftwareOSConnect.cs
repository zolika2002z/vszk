namespace vszk.Models
{
    public class SoftwareOSConnect
    {
        [Key]
        [ForeignKey("SoftwareOSConnect")]
        public int SoconnectID { get; set; }
        
        [Required]
        public OS OS { get; set; }       
        
        [Required]
        public Software Software { get; set; } 
    }
}