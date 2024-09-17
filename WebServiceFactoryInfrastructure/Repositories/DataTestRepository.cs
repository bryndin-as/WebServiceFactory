using Microsoft.Extensions.Logging;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Services;

namespace WebServiceFactoryInfrastructure.Repositories
{
    public class DataTestRepository : IDataTestRepository
    {
        private readonly ILogger<DataTestRepository> _logger;
        private readonly FillerBd _fillerBd;

        public DataTestRepository(ILogger<DataTestRepository> logger, FillerBd fillerBd)
        {
            _logger = logger;
            _fillerBd = fillerBd;
        }

        public async Task SetDataTest(int count)
        {
            try
            {
                await _fillerBd.AddRegion(count);
                await _fillerBd.AddFacility(count);
                await _fillerBd.AddTechUnit(count);
                await _fillerBd.AddEquipmentGroup(count);
                await _fillerBd.AddHardwareType(count);
                await _fillerBd.AddHardware(count);

            }
            catch (Exception)
            {
                _logger.LogError("Не удалось записать тестовые данные в бд");
                throw new InvalidOperationException();
            }
        }
    }
}
