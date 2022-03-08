﻿using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interface;
using MicroRabbit.Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;  
        }
        public IEnumerable<Account> GetAccounts()
        {
           return _ctx.Accounts;
        }
    }
}
