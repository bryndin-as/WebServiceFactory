using WebServiceFactoryContracts.Repositories;
using WebServiceFactoryModel.Entities;

namespace WebServiceFactoryContracts
{
    public interface IUnitOfWork
    {
        IGenericRepository<Region> RegionRepository { get; } 
         
        IGenericRepository<Facility> FacilityRepository { get; } 

        IGenericRepository<TechUnit> TechUnitRepository { get; } 

        IGenericRepository<EquipmentGroup> EquipmentGroupRepository { get; }  

        IGenericRepository<HardwareType> HardwareTypeRepository { get; }   

        IGenericRepository<Hardware> HardwareRepository { get; }     

    }
}
