using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO
{
    public class ProductDTO {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Vote { get; set; }
        public string Picture { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public List<CommentDTO> Comments { get; set; }
        public BreweryDTO Brewery { get; set; }
        public BeerDTO Beer { get; set; }
    }
}
