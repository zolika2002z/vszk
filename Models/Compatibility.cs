namespace vszk.Models
{
    public class Compatibility
    {
        [Key]
        [ForeignKey("Compatibility")]
        public int compID { get; set; }
        
        [Required]
        [StringLength(32)]
        public string device { get; set; }           
    }
}