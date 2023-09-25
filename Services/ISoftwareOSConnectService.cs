namespace vszk.Services
{
    public interface ISoftwareOSConnectService
    {
        Task<List<SoftwareOSConnect>> GetSoftwareOS();
    }
}