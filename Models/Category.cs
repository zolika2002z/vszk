namespace vszk.Models
{
    public class Category
    {
        [Key]
        [ForeignKey("Category")]
        public int CatID { get; set; }

        public string Name { get; set; }

        [Required]
        public CategoryGroup CategoryGroup { get; set; }
    }
}