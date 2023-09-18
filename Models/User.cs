namespace vszk.Models
{
    public class User
    {
        [Key]
        [ForeignKey("User")]
        public int UserID { get; set; }
        
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }
        
        public string Settlement { get; set; }
        
        public string Encrypted_password { get; set; }
    }
}