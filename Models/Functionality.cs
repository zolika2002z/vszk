namespace vszk.Models
{
    public class Functionality
    {
        [Key]
        [ForeignKey("Functionality")]
        public int FuncID { get; set; }
        
        [Required]
        [StringLength(32)]
        public string Function { get; set; }
    }
}