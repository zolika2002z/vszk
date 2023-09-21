namespace vszk.Controllers
{
    public class SoftwareFunctionsController : ControllerBase
    {
        private readonly ISoftwareFunctionService _softwareFunctionService;

        public SoftwareFunctionsController(ISoftwareFunctionService softwareFunctionService)
        {
            _softwareFunctionService = softwareFunctionService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<SoftwareFunction>>> Get()
        {
            return await _softwareFunctionService.GetSoftwaresFunctions();
        }
    }
}