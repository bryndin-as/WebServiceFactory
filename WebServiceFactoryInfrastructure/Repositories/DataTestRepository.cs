using Bogus;
using Microsoft.EntityFrameworkCore;
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
                Title = _faker.Company.CompanyName().ToString(),
                Description = _faker.Lorem.Text().ToString(),
                ShortTitle = _faker.Lorem.Text().ToString(),

            }).ToArray());

            await _context.SaveChangesAsync();
        }

        //public async Task<List<Region>> GetSosi() 
        //{
        //    var a = await _context.Regions.ToListAsync();

        //    return a;
        //}
    }
}
