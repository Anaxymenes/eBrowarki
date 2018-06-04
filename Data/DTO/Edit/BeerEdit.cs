using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO.Edit
{
    public class BeerEdit {
        public int Id { get; set; }
        public double Alcohol { get; set; }
        public List<int> BeerTypeBeerList { get; set; }
        public int ProducerId { get; set; }
    }
}
