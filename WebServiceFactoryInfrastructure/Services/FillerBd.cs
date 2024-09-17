using Bogus;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Entities;

namespace WebServiceFactoryInfrastructure.Services
{
    public class FillerBd
    {
        private readonly Faker _faker = new();
        private readonly AppDbContext _context;

        public FillerBd(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddRegion(int count)
        {
            var regions = Enumerable.Range(0, count).Select(r => new Region
            {
                Title = _faker.Address.City().ToString(),
                Description = _faker.Address.FullAddress().ToString(),
                ShortTitle = _faker.Address.CountryCode().ToString(),

            }).ToList();

            _context.Regions.AddRange(regions);
            await _context.SaveChangesAsync();

        }

        public async Task AddFacility(int count) 
        {
            var facilities = Enumerable.Range(0, count).Select(f => new Facility
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                RegionId = new Random().Next(1, _context.Regions.Count()),

            }).ToList();

            _context.Facilities.AddRange(facilities);
            await _context.SaveChangesAsync();

        }

        public async Task AddTechUnit(int count) 
        {
            var techUnits = Enumerable.Range(0, count).Select(t => new TechUnit
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                FacilityId = new Random().Next(1, _context.Facilities.Count()),

            }).ToList();

            _context.TechUnits.AddRange(techUnits);
            await _context.SaveChangesAsync();
        }

        public async Task AddEquipmentGroup(int count) 
        {
            var equipmentGroups =  Enumerable.Range(0, count).Select(t => new EquipmentGroup
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                TechUnitId = new Random().Next(1, _context.TechUnits.Count()),

            }).ToList();

            _context.EquipmentGroups.AddRange(equipmentGroups);
            await _context.SaveChangesAsync();
        }

        public async Task AddHardwareType(int count)
        {
            var hardwareTypes =  Enumerable.Range(0, count).Select(t => new HardwareType
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),

            }).ToList();

            _context.HardwareTypes.AddRange(hardwareTypes);
            await _context.SaveChangesAsync();
        }

        public async Task AddHardware(int count) 
        {
            var hardwares = Enumerable.Range(0, count).Select(t => new Hardware
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                ShortDescription = _faker.Commerce.ProductDescription().ToString(),
                Read = _faker.Commerce.ProductDescription().ToString(),
                EquipmentGroupId = new Random().Next(1, _context.EquipmentGroups.Count()),
                HardwareTypeId = new Random().Next(1, _context.HardwareTypes.Count()),

            }).ToList();

            _context.Hardwares.AddRange(hardwares);
            await _context.SaveChangesAsync();
        }
    }
}
