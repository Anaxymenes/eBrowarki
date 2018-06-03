using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class CommentRepository : ICommentRepository {
        public Comment Add(Comment entity) {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetAll() {
            throw new NotImplementedException();
        }
    }
}
