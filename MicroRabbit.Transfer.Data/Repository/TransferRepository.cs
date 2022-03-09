﻿using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Interface;
using MicroRabbit.Transfer.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;  
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
           return _ctx.TransferLogs;
        }
    }
}