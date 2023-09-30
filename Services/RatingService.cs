using vszk.Models.DTO;

namespace vszk.Services
{
    public class RatingService : IRatingService
    {
        private readonly DataContext _context;
        
        public RatingService(DataContext context)
        {
            _context = context;
        }

        public async Task<Rating> PostFeedBack(RatingDTO rate)
        {
            var star = new Star
            {
                All = rate.All_star,
                Simplicity = rate.Simplicity,
                Service = rate.Service,
                Characteristic = rate.Characteristic,
                Price_value = rate.Price_value,
                Recommendation = rate.Recommendation
            };

            var text = new TextRating
            {
                All = rate.All_text,
                Positive = rate.Positive,
                Negative = rate.Negative,
                Reason_of_use = rate.Reason_of_use,
                Duration_of_use = rate.Duration_of_use
            };

            var software = _context.Software.FirstOrDefault(x => x.SoftwareID == rate.SoftwareID);
            var user = _context.User.FirstOrDefault(x => x.UserID == rate.UserID);

            var rating = new Rating
            {
                Datumido = DateTime.Now,
                User = user,
                Software = software,
                Star = star,
                TextRating = text
            };

            _context.Rating.Add(rating);
            await _context.SaveChangesAsync();

            return rating;
        }
    }
}