using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class HardwareType : ItemBase
    {
        public ICollection<Hardware> Hardwares { get; set; }
    }
}
