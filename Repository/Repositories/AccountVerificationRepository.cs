﻿using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class AccountVerificationRepository : IAccountVerificationRepository {

        private readonly DatabaseContext _context;

        public AccountVerificationRepository(DatabaseContext context) {
            _context = context;
        }

        public AccountVerification Add(AccountVerification entity) {
            throw new NotImplementedException();
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public AccountVerification Edit(AccountVerification entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<AccountVerification> GetAll() {
            throw new NotImplementedException();
        }

        public AccountVerification GetVerificationCodeForUserByEmail(string email) {
            return _context.AccountVerification.First(x => x.Account.Email == email);
        }

        public void Save() {
            throw new NotImplementedException();
        }
    }
}
