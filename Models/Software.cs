using System.ComponentModel.DataAnnotations;

namespace vszk.Models
{
    public class Software
    {
        public int SoftwareID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]

        public Category Category { get; set; }

        [Required]
        public Company Company { get; set; }

        public int Introduction_fee { get; set; }
    }
}