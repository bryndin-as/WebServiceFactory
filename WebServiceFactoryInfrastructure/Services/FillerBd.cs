using Bogus;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Entities;

namespace WebServiceFactoryInfrastructure.Services
{
    public class FillerBd
    {
        private readonly Faker _faker = new();


        public List<Region> AddRegion(int count)
        {
            return Enumerable.Range(0, count).Select(r => new Region
            {
                Title = _faker.Address.City().ToString(),
                Description = _faker.Address.FullAddress().ToString(),
                ShortTitle = _faker.Address.CountryCode().ToString(),

            }).ToList();

        }

        public List<Facility> AddFacility(int count, int countRegion)
        {
            return Enumerable.Range(0, count).Select(f => new Facility
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                RegionId = new Random().Next(1, countRegion),

            }).ToList();

        }

        public List<TechUnit> AddTechUnit(int count, int countFacility)
        {
            return Enumerable.Range(0, count).Select(t => new TechUnit
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                FacilityId = new Random().Next(1, countFacility),

            }).ToList();
        }

        public List<EquipmentGroup> AddEquipmentGroup(int count, int countTechUnit)
        {
            return Enumerable.Range(0, count).Select(t => new EquipmentGroup
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                TechUnitId = new Random().Next(1, countTechUnit),

            }).ToList();
        }

        public List<HardwareType> AddHardwareType(int count)
        {
            return Enumerable.Range(0, count).Select(t => new HardwareType
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),

            }).ToList();
        }

        public List<Hardware> AddHardware(int count, int countEquipmentGroup, int countHardwareType)
        {
            return Enumerable.Range(0, count).Select(t => new Hardware
            {
                Title = _faker.Commerce.ProductName().ToString(),
                Description = _faker.Commerce.ProductDescription().ToString(),
                ShortTitle = _faker.Commerce.Product().ToString(),
                ShortDescription = _faker.Commerce.ProductDescription().ToString(),
                Read = _faker.Commerce.ProductDescription().ToString(),
                EquipmentGroupId = new Random().Next(1, countEquipmentGroup),
                HardwareTypeId = new Random().Next(1, countHardwareType),

            }).ToList();
        }
    }
}
