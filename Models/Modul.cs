namespace vszk.Models
{
    public class Modul
    {
        [Key]
        [ForeignKey("Modul")]
        public int ModulID { get; set; }

        public string Name { get; set; }     
    }
}