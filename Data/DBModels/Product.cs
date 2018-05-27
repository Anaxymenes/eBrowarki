using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Product:Entity{

        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
        public bool IsBeer { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Beer Beer { get; set; }
        public Brewery Brewery { get; set; }

        public ICollection<Vote> Votes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
