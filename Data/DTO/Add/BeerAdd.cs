﻿using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO.Add
{
    public class BeerAdd : ProductAdd
    {
        public double Alcohol { get; set; }
        //public int BeerTypeId { get; set; }
        //public List<BeerTypeBeerDTO> BeerTypeBeerList { get; set; }
        public List<int> BeerTypeBeerList { get; set; }
        public int ProducerId { get; set; }
    }
}
