namespace vszk.Models
{
    public class CatFuncConnect
    {
        [Key]
        [ForeignKey("CatFuncConnect")]
        public int CfConnectID { get; set; }

        [Required]
        public Functionality Functionality { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}