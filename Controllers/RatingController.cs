namespace vszk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        
        [HttpPost]
        public async Task<IActionResult> NewRate([FromBody] RatingDTO rate)
        {
            return Ok(await _ratingService.PostFeedBack(rate));
        }
    }
}