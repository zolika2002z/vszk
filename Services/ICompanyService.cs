namespace vszk.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanies();
    }
}