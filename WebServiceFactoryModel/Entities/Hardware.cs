using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class Hardware : ItemBase
    {
        public string ShortDescription { get; set; }

        public string Read { get; set; }

        public int EquipmentGroupId { get; set; }

        public EquipmentGroup EquipmentGroup { get; set; }

        public int HardwareTypeId { get; set; }

        public HardwareType HardwareType { get; set; }
    }
}
