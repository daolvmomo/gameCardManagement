using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GameCardInfoService
    {
        private GameCardInfoRepository _repo = new GameCardInfoRepository();
        public List<GameCardinfoDTO> GetAllGameCardInfo()
        {
            List<GameCardinfoDTO> gameCardList = _repo.GetAll().Select(x =>
                new GameCardinfoDTO
                {
                    GameCardId = x.GameCardId,
                    GameCardName = x.GameCardName,
                    GameDescription = x.GameDescription,
                    GamePlatform = x.GamePlatform,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    CreatedDate = x.CreatedDate,
                    ProviderId = x.ProviderId,
                    ProviderName = x.Provider.ProviderName,
                }
            ).ToList();
            if (gameCardList == null)
                throw new Exception("List is empty");
            return gameCardList;
        }
        public GameCardInfo? GetAGameCard(int id) => _repo.Get(id);
        public void Add(GameCardInfo gamecard)
        {
            if (_repo.Get(gamecard.GameCardId) == null)
                throw new Exception("The gamecard is not exist!");

            if (gamecard.GameCardName.Length > 60
                 || gamecard.GameCardName.Length < 2)
                throw new Exception("GameCardName is int he range of 5 - 80 characters!");

            if (!gamecard.GameCardName.Equals(@"[a-zA-Z0-9]"))
                throw new Exception("GameCardName is not allowed with special characters!");

            if (gamecard.Price.Equals(@"^\d+(\.\d+)?$")
                && gamecard.Quantity.Equals(@"^\d+$"))
                throw new Exception("Price or Quantity is wrong format!");

            if (gamecard.Price < 0
                && gamecard.Quantity < 0)
                throw new Exception("Price or Quantity must be equal or greater than 0!");

            if (_repo.Get(gamecard.GameCardId) != null)
                throw new Exception("This id is exist!");
            _repo.Add(gamecard);
        }

        public void Update(GameCardInfo gamecard)
        {
            if (_repo.Get(gamecard.GameCardId) == null)
                throw new Exception("The gamecard is not exist!");

            if (gamecard.GameCardName.Length > 60
                 || gamecard.GameCardName.Length < 2)
                throw new Exception("GameCardName is int he range of 5 - 80 characters!");

            if (!gamecard.GameCardName.Equals(@"[a-zA-Z0-9]"))
                throw new Exception("GameCardName is not allowed with special characters!");

            if (gamecard.Price.Equals(@"^\d+(\.\d+)?$")
                && gamecard.Quantity.Equals(@"^\d+$"))
                throw new Exception("Price or Quantity is wrong format!");

            if (gamecard.Price < 0
                && gamecard.Quantity < 0)
                throw new Exception("Price or Quantity must be equal or greater than 0!");

            if (_repo.Get(gamecard.GameCardId) != null)
                throw new Exception("This id is exist!");
            _repo.Update(gamecard);
        }

        public void Delete(int id)
        {
            if (_repo.Get(id) == null)
                throw new Exception("The gamecard is not exist!");
            _repo.Delete(id);
        }

        public List<GameCardInfo> SearchGameCards(string keyword)
        {
            if (!keyword.Equals(@"^\d+(\.\d+)?$"))
                return _repo.GetAll().Where(s => s.GamePlatform.ToLower().Contains(keyword)).ToList();
            else
                return _repo.GetAll().Where(s => s.Price == decimal.Parse(keyword)).ToList();
        }
    }
}
