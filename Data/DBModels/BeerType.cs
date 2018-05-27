using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class BeerType: Entity
    {
        public string Name { get; set; }

        public ICollection<Beer> Beers { get; set; }
    }
}
