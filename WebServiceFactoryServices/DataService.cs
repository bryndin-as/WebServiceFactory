using AutoMapper;
using WebServiceFactoryContracts;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryCore;
using WebServiceFactoryDto;
using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryServices
{
    public class DataService(IUnitOfWork _db, IMapper _mapper) : IDataService
    {
        private readonly IUnitOfWork db = _db;
        private readonly IMapper mapper = _mapper;

        public async Task<int> CreateRegionAsync(RegionCreateDTO item)
        {
            //var reg = mapper.Map<Region>(item);
            //await db.RegionRepository.CreateAsync(reg);
            //return reg.Id;

            return await CreateItemBaseAsync(item, db.RegionRepository);
        }

        public async Task<int> CreateFacilityAsync(FacilityCreateDTO item)
        {
            return await CreateItemBaseAsync(item, db.FacilityRepository);
        }

        public async Task<int> CreateTechUnitAsync(TechUnitCreateDTO item)
        {
            return await CreateItemBaseAsync(item, db.TechUnitRepository);
        }

        public async Task<int> CreateEquipmentGroupAsync(EquipmentGroupCreateDTO item)
        {
            return await CreateItemBaseAsync(item, db.EquipmentGroupRepository);
        }

        public async Task<int> CreateHardwareTypeAsync(HardwareTypeCreateDTO item)
        {
            return await CreateItemBaseAsync(item, db.HardwareTypeRepository);
        }

        public async Task<int> CreateHardwareAsync(HardwareCreateDTO item)
        {
            return await CreateItemBaseAsync(item, db.HardwareRepository);
        }


        async Task<int> CreateItemBaseAsync<T, D>(D dim, IGenericRepository<T> repo)
    where D : class where T : ItemBase
        {
            var item = mapper.Map<T>(dim);
            await repo.CreateAsync(item);
            return item.Id;
        }



    }
}
