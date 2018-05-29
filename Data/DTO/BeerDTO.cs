using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO
{
    public class BeerDTO {
       
        public double Alcohol { get; set; }
        //public List<BeerTypeBeerDTO> BeerTypeBeerDTO { get; set; }
        public string Producer { get; set; }
        public int ProducerId { get; set; }
    }
}
