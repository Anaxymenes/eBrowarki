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

        public bool Delete(int id, int userId) {
            var user = _context.Account.First(x => x.Id == userId);
            var obj = _context.Comment.First(x => x.Id == id);
            if(user.Role.Name == "Admin" || user.Role.Name== "Moderator" || obj.AccountId == userId) {
                try {
                    _context.Remove(obj);
                    _context.SaveChanges();
                    return true;
                }catch(Exception e) {
                    return false;
                }
            }
            return false;
        }

        public Comment Edit(Comment entity, int userId) {
            var user = _context.Account.First(x => x.Id == userId);
            if (user.Role.Name == "Admin" || user.Role.Name == "Moderator" || entity.AccountId == userId) {
                try {
                    _context.Update(entity);
                    _context.SaveChanges();
                    return entity;
                } catch (Exception e) {
                    return null;
                }
            };
            return null;
        }

        public IQueryable<Comment> GetAll() {
            throw new NotImplementedException();
        }
    }
}
