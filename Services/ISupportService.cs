namespace vszk.Services
{
    public interface ISupportService
    {
        Task<List<Support>> GetSupports();
    }
}