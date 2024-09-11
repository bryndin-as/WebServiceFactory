using Microsoft.AspNetCore.Mvc;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Entities;
using WebServiceFactoryInfrastructure.Repositories;

namespace WebServiceFactory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataTestController : ControllerBase
    {
        private readonly IDataTestRepository _dataTestRepository;

        public DataTestController(IDataTestRepository dataTestRepositoryуу)
        {
            _dataTestRepository = dataTestRepositoryуу;
        }

        [HttpPost]
        public async Task<IActionResult> AddDataSet(int count)
        {
            await _dataTestRepository.SetDataTest(count);
            return Ok();
        }
    }
}
