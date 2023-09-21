namespace vszk.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly DataContext _context;
        
        public CompanyService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _context.Company.ToListAsync();
        }
    }
}