namespace vszk.Services
{
    public interface ISoftwareLangConnectService
    {
        Task<List<SoftwareLangConnect>> GetSoftwareLanguages();
    }
}