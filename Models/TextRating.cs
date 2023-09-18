namespace vszk.Models
{
    public class TextRating
    {      
        [Key]
        [ForeignKey("TextRating")]  
        public int TextratingID { get; set; }
        
        public string All { get; set; }
        
        public string Positive { get; set; }
        
        public string Negative { get; set; }
        
        public string Reason_of_use { get; set; }
        
        public string Duration_of_use { get; set; }
    }
}