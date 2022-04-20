using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAmalt.Dto
{
    public class CityDto
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CityDto (string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
    public class GraphCityDto
    {
        public List<CityDto> CityDtos { get; set; }

        public GraphCityDto(List<CityDto> cityDtos)
        {
            CityDtos = cityDtos;
        }
    }
}
