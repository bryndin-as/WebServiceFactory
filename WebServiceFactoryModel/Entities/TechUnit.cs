using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class TechUnit : ItemBase
    {
        public int FacilityId { get; set; }

        public Facility Facility { get; set; }

        public ICollection<EquipmentGroup> EquipmentGroups { get; set; }
    }
}
