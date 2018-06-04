using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO.Edit
{
    public class ProductEdit {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Picture { get; set; }
        public int CountryId { get; set; }
        public BreweryEdit Brewery { get; set; }
        public BeerEdit Beer { get; set; }
    }
}
