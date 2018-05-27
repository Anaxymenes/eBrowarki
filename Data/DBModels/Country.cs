using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Country : Entity{

        public string Name { get; set; }
        public string Shortcut { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
