using WebServiceFactoryModel.Entities.Base;

namespace WebServiceFactoryModel.Entities
{
    public class Region : ItemBase
    {
        public ICollection<Facility> Facilities { get; set; }
    }
}
