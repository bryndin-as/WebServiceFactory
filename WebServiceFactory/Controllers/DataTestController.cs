using Microsoft.AspNetCore.Mvc;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryCore;
using WebServiceFactoryDto;

namespace WebServiceFactory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataTestController : ControllerBase
    {
        private readonly IDataService _dataService;
        private readonly IDataTestRepository _dataTestRepository;

        public DataTestController(IDataService dataService, IDataTestRepository dataTestRepository)
        {
            _dataService = dataService;
            _dataTestRepository = dataTestRepository;
        }

        [HttpPost("addTestData")]
        public async Task<IActionResult> AddDataSet(int count)
        {
            await _dataTestRepository.SetDataTest(count);
            return Ok();
        }

        [HttpPost("createRegion")]
        public async Task<IActionResult> CreateRegion(RegionCreateDTO regionCreateDTO)
        {
            await _dataService.CreateRegionAsync(regionCreateDTO);
            return Ok();
        }




    }
}
