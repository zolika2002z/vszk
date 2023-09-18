namespace vszk.Models
{
    public class SoftwareFunction
    {
        [Key]
        [ForeignKey("SoftwareFunction")]
        public int SoftwarefuncID { get; set; }
        
        public bool Sfunction { get; set; }

        [Required]
        public Software Software { get; set; }

        [Required]
        public Functionality Functionality { get; set; }
        
    }
}