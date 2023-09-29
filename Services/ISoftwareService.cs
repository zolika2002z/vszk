namespace vszk.Services
{
    public interface ISoftwareService
    {
        Task<List<SoftwareDTO>> GetAllSoftwares();

        Task<Software> GetSoftwareById(int id);
    }
}