using WebServiceFactoryInfrastructure.Entities.Base;

namespace WebServiceFactoryInfrastructure.Entities
{
    public class TechUnit : ItemBase
    {
        public int FacilityId { get; set; }

        public Facility Facility { get; set; }

        public ICollection<EquipmentGroup> EquipmentGroups { get; set; } 
    }
}
