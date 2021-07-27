using System.Collections.Generic;
using entity;
namespace data.Abstract
{
    public interface IPlayerRepository:IRepository<Player>
    {
        public List<Player> getAllPlayersInclude();

        public Player getAllPlayersInclude(int id);

        public List<Player> searchPlay(string name);
    }
}