namespace vszk.Models
{
    public class Functionality
    {
        [Key]
        [ForeignKey("Functionality")]
        public int FunctionalityID { get; set; }
        
        [Required]
        [StringLength(32)]
        public string Function { get; set; }
    }
}