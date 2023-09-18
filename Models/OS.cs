namespace vszk.Models
{
    public class OS
    {
        [Key]
        [ForeignKey("OS")]
        public int OsID { get; set; }
        
        [Required]
        [StringLength(32)]
        public string Os { get; set; }        
    }
}