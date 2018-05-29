using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Beer : Entity
    {
        public double Alcohol { get; set; }

        
        public Brewery Brewery { get; set; }
        public int BreweryId { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public ICollection<BeerTypeBeer> BeerTypeBeers { get; set; }

    }
}
