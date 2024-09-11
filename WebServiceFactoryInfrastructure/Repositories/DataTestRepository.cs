using Bogus;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Entities;

namespace WebServiceFactoryInfrastructure.Repositories
{
    public class DataTestRepository : IDataTestRepository
    {
        private readonly AppDbContext _context;
        private readonly Faker _faker = new();

        public DataTestRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task SetDataTest(int count)
        {
            _context.Regions.AddRange(Enumerable.Range(0, count).Select(r => new Region
            {
                Title = _faker.Address.City().ToString(),
                Description = _faker.Address.FullAddress().ToString(), 
                ShortTitle = _faker.Address.CountryCode().ToString(),

            }).ToArray());

            await _context.SaveChangesAsync();

            _context.Facilities.AddRange(Enumerable.Range(0, count).Select(f => new Facility
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),  
                ShortTitle = _faker.Commerce.Product().ToString(),
                RegionId = new Random().Next(1,count),
            }));

            await _context.SaveChangesAsync();

            _context.TechUnits.AddRange(Enumerable.Range(0, count).Select(t => new TechUnit
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                FacilityId = new Random().Next(1,count),    

            }));

            await _context.SaveChangesAsync();

            _context.EquipmentGroups.AddRange(Enumerable.Range(0, count).Select(t => new EquipmentGroup
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                TechUnitId = new Random().Next(1, count),

            }));

            await _context.SaveChangesAsync();

            _context.HardwareTypes.AddRange(Enumerable.Range(0, count).Select(t => new HardwareType
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),

            }));

            await _context.SaveChangesAsync();

            _context.Hardwares.AddRange(Enumerable.Range(0, count).Select(t => new Hardware
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                ShortDescription = _faker.Commerce.ProductDescription().ToString(),
                Read = _faker.Commerce.ProductDescription().ToString(),
                EquipmentGroupId = new Random().Next(1, count),
                HardwareTypeId = new Random().Next(1, count),

            }));

            await _context.SaveChangesAsync();
        }
    }
}
