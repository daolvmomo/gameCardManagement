using Repository;
using Repository.Entities;

namespace Services
{
    public class MemberAccountService
    {
        private MemberAccountRepository _repo = new MemberAccountRepository();
        public MemberAccount? CheckLogin(string email)
        {       
            return _repo.Get(email);
        }
    }
}