using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto.Base;

namespace WebServiceFactoryDto
{

    [Serializable]
    public class EquipmentGroupCreateDTO : BaseDTO
    {

    }

    [Serializable]
    public class EquipmentGroupUpdateDTO : BaseDTO
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class EquipmentGroupBaseDTO : BaseDTO
    {
        public int Id { get; set; }
    }
}
