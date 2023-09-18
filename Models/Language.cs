namespace vszk.Models
{
    public class Language
    {
        [Key]
        [ForeignKey("Language")]
        public int langID { get; set; }
        
        public string Lang { get; set; }        
    }
}