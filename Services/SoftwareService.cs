namespace vszk.Services
{
    public class SoftwareService : ISoftwareService
    {
        private readonly DataContext _context;
        
        public SoftwareService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Software>> GetAllSoftwares()
        {
            return await _context.Software.Include(x => x.Category).Include(x => x.Company).Include(x => x.Category.CategoryGroup).ToListAsync();
        }

        public async Task<Software> GetSoftwareById(int id)
        {
            var software = _context.Software.FirstOrDefaultAsync(x => x.SoftwareID == id);
            if(software is not null) return await software;
            throw new Exception("Software not found");
        }
    }
}