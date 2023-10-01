namespace vszk.Models
{
    public class SoftwareDTO
    {
        public int SoftwareID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public Company Company { get; set; }

        public int? Introduction_fee { get; set; }

        public string Logo_link { get; set; }

        public float Average_stars { get; set; }

        public List<Language> Languages { get; set; }

        public List<Language> Supports { get; set; }

        public List<OS> OSs { get; set; }

        public List<Compatibility> Devices { get; set; }

        public List<Modul> Moduls { get; set; }

        public List<RemunerationDTO> Remunerations { get; set; }

        public List<SoftwareFunctionsDTO> Functions { get; set; }
    }
}