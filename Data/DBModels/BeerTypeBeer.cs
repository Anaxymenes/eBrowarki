using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class BeerTypeBeer : Entity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BeerTypeId { get; set; }
        public BeerType BeerType { get; set; }
    }
}
