namespace vszk.Models.DTO
{
    public class RemunerationDTO
    {
        public int RemunerationID { get; set; }

        public Level Level { get; set; }

        public string Type { get; set; }
        
        public int? Price { get; set; }
    }
}