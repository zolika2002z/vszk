namespace vszk.Models
{
    public class OS
    {
        [Key]
        [ForeignKey("OS")]
        public int OsID { get; set; }
        
        public string Os { get; set; }        
    }
}