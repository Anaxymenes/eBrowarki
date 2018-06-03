using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO.Edit
{
    public class CommentEdit {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }

    }
}
