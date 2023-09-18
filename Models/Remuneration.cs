namespace vszk.Models
{
    public class Remuneration
    {
        [Key]
        [ForeignKey("Remuneration")]
        public int RemID { get; set; }

        [Required]
        public Software Software { get; set; }

        [Required]
        public Level Level { get; set; }

        public int Monthly_price { get; set; }
    }
}