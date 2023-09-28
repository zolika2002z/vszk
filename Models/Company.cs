namespace vszk.Models
{
    public class Company
    {
        [Key]
        [ForeignKey("Company")]
        public int CompanyID { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Location { get; set; }
        
        [Column(TypeName = "char(12)")]
        public string Phone { get; set; }
        
        [StringLength(64)]
        public string Website { get; set; }
        
        [StringLength(128)]
        public string Logo_link { get; set; }
    }
}