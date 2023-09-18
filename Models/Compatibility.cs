namespace vszk.Models
{
    public class Compatibility
    {
        [Key]
        [ForeignKey("Compatibility")]
        public int compID { get; set; }
        
        public string device { get; set; }           
    }
}