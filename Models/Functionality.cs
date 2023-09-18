namespace vszk.Models
{
    public class Functionality
    {
        [Key]
        [ForeignKey("Functionality")]
        public int FuncID { get; set; }
        
        public string Function { get; set; }
    }
}