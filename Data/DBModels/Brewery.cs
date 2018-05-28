using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Brewery : Entity {
        
        public string Place { get; set; }
        public string PostalCode { get; set; }
        public string PostOffice { get; set; }
        public string Street { get; set; }
        public string NumberOfBuilding { get; set; }

        public int ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        [JsonIgnore]
        public ICollection<Beer> Beers { get; set; }
        
    }
}
