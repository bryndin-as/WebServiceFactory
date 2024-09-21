using AutoMapper;
using WebServiceFactoryDto;
using WebServiceFactoryModel.Entities;

namespace WebServiceFactoryServices.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegionCreateDTO, Region>();
            CreateMap<FacilityCreateDTO, Facility>();
            CreateMap<TechUnitCreateDTO, TechUnit>();
            CreateMap<EquipmentGroupCreateDTO, EquipmentGroup>();
            CreateMap<HardwareTypeCreateDTO, HardwareType>();
            CreateMap<HardwareCreateDTO, Hardware>();
        }
    }
}
