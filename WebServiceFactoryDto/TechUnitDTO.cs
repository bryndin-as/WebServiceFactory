using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto.Base;

namespace WebServiceFactoryDto
{
    
    [Serializable]
    public class TechUnitCreateDTO : BaseDTO
    {

    }

    [Serializable]
    public class TechUnitUpdateDTO : BaseDTO
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class TechUnitBaseDTO : BaseDTO
    {
        public int Id { get; set; }
    }
}
