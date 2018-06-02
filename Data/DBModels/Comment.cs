using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBModels
{
    public class Comment : Entity {
        public DateTime Date { get; set; }
        public string Content { get; set; }
        

        public Account Account { get; set; }
        public int AccountId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        



    }
}
