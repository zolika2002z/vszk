namespace vszk.Models
{
    public class CategoryGroup
    {
        [Key]
        [ForeignKey("CategoryGroup")]
        public int CatgroupID { get; set; }
        
        public string Name { get; set; }
    }
}