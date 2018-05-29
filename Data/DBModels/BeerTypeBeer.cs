using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class BeerTypeBeer : Entity
    {
        public int BeerId { get; set; }
        public Beer Beer { get; set; }
        public int BeerTypeId { get; set; }
        public BeerType BeerType { get; set; }
    }
}
