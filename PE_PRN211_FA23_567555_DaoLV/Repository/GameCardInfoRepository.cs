using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Repositories;

namespace Repository
{
    public class GameCardInfoRepository
    {
        private GameCard2023DbContext db = new GameCard2023DbContext();
        public GameCardInfo Get(int id)
        {
            var gamecard = db.GameCardInfos.FirstOrDefault(x => x.GameCardId == id);
            return gamecard;
        }
        public List<GameCardInfo> GetAll() => db.GameCardInfos.Include("Provider").ToList();
        public void Add(GameCardInfo gamecard)
        {
            db.GameCardInfos.Add(gamecard);
            db.SaveChanges();
        }
        public void Update(GameCardInfo gamecard)
        {
            db.GameCardInfos.Update(gamecard);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.GameCardInfos.Remove(db.GameCardInfos.FirstOrDefault(x => x.GameCardId == id));
            db.SaveChanges();
        }
    }
}