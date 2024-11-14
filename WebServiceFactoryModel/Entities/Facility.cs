using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class Facility : ItemBase
    {
        public int RegionId { get; set; }

        public Region Region { get; set; }

        public ICollection<TechUnit> TechUnits { get; set; }
    }
}
