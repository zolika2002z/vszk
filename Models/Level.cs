namespace vszk.Models
{
    public class Level
    {
        [Key]
        [ForeignKey("Level")]
        public int LevelID { get; set; }
        
        public string name { get; set; }
    }
}