using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto.Base;

namespace WebServiceFactoryDto
{
    
    [Serializable]
    public class FacilityCreateDTO : BaseDTO
    {

    }

    [Serializable]
    public class FacilityUpdateDTO : BaseDTO
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class FacilityBaseDTO : BaseDTO
    {
        public int Id { get; set; }
    }
}
