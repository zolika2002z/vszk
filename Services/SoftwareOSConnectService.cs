namespace vszk.Services
{
    public class SoftwareOSConnectService : ISoftwareOSConnectService
    {
        private readonly DataContext _context;
        
        public SoftwareOSConnectService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SoftwareOSConnect>> GetSoftwareOS()
        {
            return await _context.SoftwareOSConnect.Include(x => x.Software).Include(x => x.OS).ToListAsync();
        }
    }
}