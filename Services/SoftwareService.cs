namespace vszk.Services
{
    public class SoftwareService : ISoftwareService
    {
        private readonly DataContext _context;
        
        public SoftwareService(DataContext context)
        {
            _context = context;
        }

        private float CalculateAverageStars(Software software)
        {
            var ratings = _context.Rating
                .Where(r => r.Software.SoftwareID == software.SoftwareID)
                .Include(r => r.Star)
                .ToList();

            if (ratings.Count == 0)
            {
                return 0;
            }

            float totalStars = 0;

            foreach (var rating in ratings)
            {
                float? starSum = rating.Star.All + rating.Star.Simplicity + rating.Star.Service + rating.Star.Characteristic + rating.Star.Price_value;
                totalStars += (float) starSum / 5;
            }

            float averageStars = totalStars / ratings.Count;
            return averageStars;
        }

        public async Task<List<SoftwareDTO>> GetAllSoftwares()
        {
            var softwareDTOs = await _context.Software
                .Include(x => x.Category)
                .Include(x => x.Company)
                .Include(x => x.Category.CategoryGroup)
                .ToListAsync();

            var softwareDTOsWithAverageStars = softwareDTOs.Select(software => new SoftwareDTO
            {
                SoftwareID = software.SoftwareID,
                Name = software.Name,
                Description = software.Description,
                Category = software.Category,
                Company = software.Company,
                Introduction_fee = software.Introduction_fee,
                Logo_link = software.Logo_link,
                Average_stars = CalculateAverageStars(software),
                Languages = _context.SoftwareLangConnect.Include(x => x.Language).Include(x => x.Software).Where(x => x.Software.SoftwareID == software.SoftwareID).Select(x => x.Language).ToList(),
                Supports = _context.Support.Include(x => x.Language).Include(x => x.Software).Where(x => x.Software.SoftwareID == software.SoftwareID).Select(x => x.Language).ToList(),
                OSs = _context.SoftwareOSConnect.Include(x => x.OS).Include(x => x.Software).Where(x => x.Software.SoftwareID == software.SoftwareID).Select(x => x.OS).ToList(),
                Devices = _context.SoftwareCompConnect.Include(x => x.Compatibility).Include(x => x.Software).Where(x => x.Software.SoftwareID == software.SoftwareID).Select(x => x.Compatibility).ToList(),
                Moduls = _context.SoftwareModulConnect.Include(x => x.Modul).Include(x => x.Software).Where(x => x.Software.SoftwareID == software.SoftwareID).Select(x => x.Modul).ToList(),
                Remunerations = _context.Remuneration
                    .Include(x => x.Level)
                    .Where(x => x.Software.SoftwareID == software.SoftwareID)
                    .Select(x => new RemunerationDTO
                    {
                        RemunerationID = x.RemunerationID,
                        Level = x.Level,
                        Type = x.Type,
                        Price = x.Price
                    })
                    .ToList(),
                Functions = _context.SoftwareFunction
                    .Include(x => x.Functionality)
                    .Where(x => x.Software.SoftwareID == software.SoftwareID)
                    .Select(x => new SoftwareFunctionsDTO
                    {
                        SoftwareFunctionID = x.SoftwareFunctionID,
                        Sfunction = x.Sfunction,
                        Functionality = x.Functionality
                    })
                    .ToList()
            }).ToList();

            return softwareDTOsWithAverageStars;
        }

        public async Task<Software> GetSoftwareById(int id)
        {
            var software = _context.Software.FirstOrDefaultAsync(x => x.SoftwareID == id);
            if(software is not null) return await software;
            throw new Exception("Software not found");
        }
    }
}