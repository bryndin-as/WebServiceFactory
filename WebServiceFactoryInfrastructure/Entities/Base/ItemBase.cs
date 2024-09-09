using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceFactoryInfrastructure.Entities.Base
{
    public class ItemBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string Description { get; set; }
    }
}
