using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Beer : Entity
    {
        public double Alcohol { get; set; }

        public BeerType BeerType { get; set; }
        public int BeerTypeId { get; set; }
        public Brewery Brewery { get; set; }
        public int BreweryId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
