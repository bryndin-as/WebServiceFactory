using WebServiceFactoryDto.Base;


namespace WebServiceFactoryDto
{
    [Serializable]
    public class RegionCreateDTO : BaseDTO
    {

    }

    [Serializable]
    public class RegionUpdateDTO : BaseDTO
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class RegionBaseDTO : BaseDTO
    {
        public int Id { get; set; }
    }
}


