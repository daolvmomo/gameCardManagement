using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProviderService
    {
        private ProviderRepository _repo = new ProviderRepository();
        public string GetName(string id)
        {
            return _repo.Get(id).ProviderName;
        }
        public List<Provider> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
