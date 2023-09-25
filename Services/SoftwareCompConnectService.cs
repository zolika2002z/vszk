namespace vszk.Services
{
    public class SoftwareCompConnectService : ISoftwareCompConnectService
    {
        private readonly DataContext _context;
        
        public SoftwareCompConnectService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SoftwareCompConnect>> GetSoftwareCompatibility()
        {
            return await _context.SoftwareCompConnect.Include(x => x.Software).Include(x => x.Compatibility).ToListAsync();
        }
    }
}