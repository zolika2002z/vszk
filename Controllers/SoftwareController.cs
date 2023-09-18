namespace vszk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoftwareController : ControllerBase
    {
        private readonly ISoftwareService _softwareService;

        public SoftwareController(ISoftwareService softwareService)
        {
            _softwareService = softwareService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Software>>> Get()
        {
            return Ok(await _softwareService.GetAllSoftwares());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Software>> GetSingle(int id)
        {
            return Ok(await _softwareService.GetSoftwareById(id));
        }
    }
}