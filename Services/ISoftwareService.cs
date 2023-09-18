namespace vszk.Services
{
    public interface ISoftwareService
    {
        Task<List<Software>> GetAllSoftwares();

        Task<Software> GetSoftwareById(int id);
    }
}