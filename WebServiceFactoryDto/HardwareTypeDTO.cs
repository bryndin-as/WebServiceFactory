using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto.Base;

namespace WebServiceFactoryDto
{

    [Serializable]
    public class HardwareTypeCreateDTO : BaseDTO
    {

    }

    [Serializable]
    public class HardwareTypeUpdateDTO : BaseDTO
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class HardwareTypeBaseDTO : BaseDTO
    {
        public int Id { get; set; }
    }
}
