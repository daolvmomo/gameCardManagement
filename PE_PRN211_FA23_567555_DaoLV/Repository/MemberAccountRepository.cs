using Repository.Entities;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MemberAccountRepository
    {
        private GameCard2023DbContext db = new GameCard2023DbContext();
        public MemberAccount? Get(string email)
        { 
            return db.MemberAccounts.FirstOrDefault(x => x.MemberEmail == email);
        }
    }
}
