using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Vote : Entity {
        public int VoteValue { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
