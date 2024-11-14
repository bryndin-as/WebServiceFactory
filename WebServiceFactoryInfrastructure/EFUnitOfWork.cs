using WebServiceFactoryContracts;
using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Repositories.Module;
using WebServiceFactoryModel.Entities;

namespace WebServiceFactoryInfrastructure
{
    public class EFUnitOfWork(AppDbContext context) : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext db = context;

        RegionRepository? regionRepository; 

        FacilityRepository? facilityRepository; 
        
        TechUnitRepository? techUnitRepository;   

        EquipmentGroupRepository? equipmentGroupRepository;   
        
        HardwareTypeRepository? hardwareTypeRepository;  
        
        HardwareRepository? hardwareRepository;      

        public IGenericRepository<Region> RegionRepository =>
            regionRepository ??= new RegionRepository(db);

        public IGenericRepository<Facility> FacilityRepository => 
            facilityRepository ??= new FacilityRepository(db);

        public IGenericRepository<TechUnit> TechUnitRepository => 
            techUnitRepository ??= new TechUnitRepository(db);

        public IGenericRepository<EquipmentGroup> EquipmentGroupRepository => 
            equipmentGroupRepository ??= new EquipmentGroupRepository(db);

        public IGenericRepository<HardwareType> HardwareTypeRepository =>
            hardwareTypeRepository ??= new HardwareTypeRepository(db);

        public IGenericRepository<Hardware> HardwareRepository => 
            hardwareRepository ??= new HardwareRepository(db);


        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
