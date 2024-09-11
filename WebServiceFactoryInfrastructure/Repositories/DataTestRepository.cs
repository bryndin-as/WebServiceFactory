using Bogus;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Entities;
using WebServiceFactoryInfrastructure.Services;

namespace WebServiceFactoryInfrastructure.Repositories
{
    public class DataTestRepository : IDataTestRepository
    {
        private readonly AppDbContext _context;
        private readonly FillerBd _fillerBd = new();
         
        public DataTestRepository(AppDbContext context)
        {
            _context = context;

        }

        public async Task SetDataTest(int count)
        {
            var regions = _fillerBd.AddRegion(count);
            _context.Regions.AddRange(regions);
            await _context.SaveChangesAsync();

            var facilities = _fillerBd.AddFacility(count, _context.Regions.Count());
            _context.Facilities.AddRange(facilities);
            await _context.SaveChangesAsync();

            var techUnits = _fillerBd.AddTechUnit(count, _context.Facilities.Count());
            _context.TechUnits.AddRange(techUnits);
            await _context.SaveChangesAsync();

            var equipmentGroups = _fillerBd.AddEquipmentGroup(count, _context.TechUnits.Count() );
            _context.EquipmentGroups.AddRange(equipmentGroups);
            await _context.SaveChangesAsync();

            var hardwareTypes = _fillerBd.AddHardwareType(count);
            _context.HardwareTypes.AddRange(hardwareTypes);
            await _context.SaveChangesAsync();

            var hardwares = _fillerBd.AddHardware(count, _context.EquipmentGroups.Count(), _context.HardwareTypes.Count());
            _context.Hardwares.AddRange(hardwares);
            await _context.SaveChangesAsync();

        }
    }
}
