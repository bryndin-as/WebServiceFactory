using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceFactoryDto.Base;

namespace WebServiceFactoryDto
{
    internal class HardwareDTO
    {
    }

    [Serializable]
    public class HardwareCreateDTO : BaseDTO
    {
        public string ShortDescription { get; set; }

        public string Read { get; set; }
    }

    [Serializable]
    public class HardwareUpdateDTO : BaseDTO
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string Read { get; set; }
    }

    [Serializable]
    public class HardwareBaseDTO : BaseDTO
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string Read { get; set; }
    }
}
