using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO.Add
{
    public class BreweryAdd: ProductAdd {
        public string Place { get; set; }
        public string PostalCode { get; set; }
        public string PostOffice { get; set; }
        public string Street { get; set; }
        public string NumberOfBuilding { get; set; }
    }
}
