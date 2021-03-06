using MicroRabbit.Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Interface
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
