using WebServiceFactoryInfrastructure.Entities.Base;

namespace WebServiceFactoryInfrastructure.Entities
{
    public class Facility : ItemBase
    {
        public int RegionId { get; set; }  

        public Region Region { get; set; }

        public ICollection<TechUnit> TechUnits { get; set; } 
    }
}
