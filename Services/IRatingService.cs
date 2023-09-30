namespace vszk.Services
{
    public interface IRatingService
    {
        Task<Rating> PostFeedBack(RatingDTO rate);
    }
}