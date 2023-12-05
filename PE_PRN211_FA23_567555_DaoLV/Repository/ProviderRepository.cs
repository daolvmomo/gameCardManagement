using Repository.Entities;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProviderRepository
    {
        private GameCard2023DbContext db = new GameCard2023DbContext();
        public Provider Get(string id)
        {
            var provider = db.Providers.FirstOrDefault(x => x.ProviderId == id);
            return provider;
        }
        public List<Provider> GetAll() => db.Providers.ToList();
    }
}
