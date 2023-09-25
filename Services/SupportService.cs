namespace vszk.Services
{
    public class SupportService : ISupportService
    {
        private readonly DataContext _context;
        
        public SupportService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Support>> GetSupports()
        {
            return await _context.Support.Include(x => x.Software).Include(x => x.Language).ToListAsync();
        }
    }
}