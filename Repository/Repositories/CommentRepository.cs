using Data.DBModels;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class CommentRepository : ICommentRepository {
        private readonly DatabaseContext _context;

        public CommentRepository(DatabaseContext context) {
            this._context = context;
        }

        public Comment Add(Comment entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
                return _context.Comment.Last();
            }catch (Exception e) {
                return null;
            }
        }

        public bool Delete(Comment entity) {
            //var user = _context.Account.Where(x => x.Id == entity.AccountId);
            //var entity = 
            return false;
        }

        public IQueryable<Comment> GetAll() {
            throw new NotImplementedException();
        }
    }
}
