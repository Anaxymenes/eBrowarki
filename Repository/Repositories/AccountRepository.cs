using Data.DBModels;
using Data.DTO;
using Data.DTO.Edit;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class AccountRepository : IAccountRepository {
        private readonly DatabaseContext _context;

        public AccountRepository(DatabaseContext context) {
            _context = context;
        }

        public bool ActiveAccount(ActivatedAccount activatedAccount) {
            if (_context.AccountVerification.Any(x => x.Account.Email == activatedAccount.Email && x.CodeVerification == activatedAccount.CodeVerification)) {
                try {
                    _context.Account.First(c => c.Email == activatedAccount.Email).Active = true;
                    var accountVerification = _context.AccountVerification.First(v =>
                    v.Account.Email == activatedAccount.Email &&
                    v.CodeVerification == activatedAccount.CodeVerification);
                    _context.AccountVerification.Remove(accountVerification);
                    _context.SaveChanges();
                    return true;
                } catch (Exception e) {
                    return false;
                }
            }
            return false;
        }

        public Account Add(Account entity) {
            throw new NotImplementedException();
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public Account Edit(Account entity, int userId) {
            throw new NotImplementedException();
        }

        public bool ExistEmail(string email) {
            return _context.Account.Any(x => x.Email == email);
            
        }

        public IQueryable<Account> GetAll() {
            throw new NotImplementedException();
        }


        public Account GetUserByUsernameOrEmail(string value) {
            try {
                var results = _context.Account.AsQueryable()
                    .Include(role => role.Role);
                return results.Where(x => x.Email == value).Single();

            } catch (Exception e) {
                return null;
            }

        }

        public void RegisterUser(Account account, AccountVerification accountVerification) {
            _context.Add(account);
            _context.SaveChanges();
            var addedAccount = _context.Account.First(x => x.Email == account.Email);
            accountVerification.AccountId = addedAccount.Id;
            _context.Add(accountVerification);
            _context.SaveChanges();
        }

        public bool UpdateRole(UpdateRole updateRole) {
            if (!_context.Account.Any(x => x.RoleId != updateRole.RoleId && x.Id == updateRole.AccountId))
                return false;
            var user = _context.Account.First(x => x.Id == updateRole.AccountId);
            user.RoleId = updateRole.RoleId;
            try {
                _context.Account.Update(user);
                _context.SaveChanges();
                return true;
            }catch (Exception e) {
                return false; 
            }
        }
    }
}
