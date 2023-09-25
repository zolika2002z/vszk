namespace vszk.Services
{
    public class SoftwareLangConnectService : ISoftwareLangConnectService
    {
        private readonly DataContext _context;
        
        public SoftwareLangConnectService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SoftwareLangConnect>> GetSoftwareLanguages()
        {
            return await _context.SoftwareLangConnect.Include(x => x.Software).Include(x => x.Language).ToListAsync();
        }
    }
}