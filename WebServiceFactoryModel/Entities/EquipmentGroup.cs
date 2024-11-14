//using WebServiceFactoryInfrastructure.Entities.Base;

using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class EquipmentGroup : ItemBase
    {
        public int TechUnitId { get; set; }

        public TechUnit TechUnit { get; set; }

        public ICollection<Hardware> Hardwares { get; set; } 
    }
}
