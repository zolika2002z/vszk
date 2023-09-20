namespace vszk.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        
        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Category.Include(x => x.CategoryGroup).ToListAsync();
        }
    }
}