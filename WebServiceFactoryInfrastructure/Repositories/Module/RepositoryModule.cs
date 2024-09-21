using WebServiceFactoryInfrastructure.Database;
using WebServiceFactoryInfrastructure.Repositories.Generic;
using WebServiceFactoryModel.Entities;

namespace WebServiceFactoryInfrastructure.Repositories.Module
{
    public class RegionRepository(AppDbContext context) 
        : GenericRepository<Region>(context) 
    { }

    public class FacilityRepository(AppDbContext context) 
        : GenericRepository<Facility>(context) 
    { }

    public class TechUnitRepository(AppDbContext context) 
        : GenericRepository<TechUnit>(context) 
    { }

    public class EquipmentGroupRepository(AppDbContext context) 
        : GenericRepository<EquipmentGroup>(context) 
    { } 

    public class HardwareTypeRepository(AppDbContext context) 
        : GenericRepository<HardwareType>(context) 
    { } 

    public class HardwareRepository(AppDbContext context) 
        : GenericRepository<Hardware>(context) 
    { }  

}
