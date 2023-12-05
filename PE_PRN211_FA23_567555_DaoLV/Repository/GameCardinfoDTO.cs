using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GameCardinfoDTO
    {
        public int GameCardId { get; set; }
        public string GameCardName { get; set; }
        public string GameDescription { get; set; }
        public string GamePlatform { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
