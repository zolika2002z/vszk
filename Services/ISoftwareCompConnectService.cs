namespace vszk.Services
{
    public interface ISoftwareCompConnectService
    {
        Task<List<SoftwareCompConnect>> GetSoftwareCompatibility();
    }
}