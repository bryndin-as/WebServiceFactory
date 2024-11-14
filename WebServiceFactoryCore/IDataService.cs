using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto;

namespace WebServiceFactoryCore
{
    public interface IDataService
    {
        //create
        Task<int> CreateRegionAsync(RegionCreateDTO item); 

        Task<int> CreateFacilityAsync(FacilityCreateDTO item); 

        Task<int> CreateTechUnitAsync(TechUnitCreateDTO item); 

        Task<int> CreateEquipmentGroupAsync(EquipmentGroupCreateDTO item); 

        Task<int> CreateHardwareTypeAsync(HardwareTypeCreateDTO item); 

        Task<int> CreateHardwareAsync(HardwareCreateDTO item);  

    }
}
