using entity;
using  data.Abstract;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace data.Concrete
{
    public class PlayerRepository : AllRepository<Player, ShopContext>, IPlayerRepository
    {
        public List<Player> getAllPlayersInclude()
        {
            using (var context = new ShopContext()){

                var players = context.players.Include(i => i.movies).ThenInclude(i=>i.movie).ToList();

                return players;
            }
            {
                
            }
        }

           public Player getAllPlayersInclude(int id)
        {
            using (var context = new ShopContext()){

                var players = context.players.Where(i => i.PlayerId == id).Include(i => i.movies).ThenInclude(i=>i.movie).FirstOrDefault();

                return players;
            }
            {
                
            }
        }

             public List<Player> searchPlay(string name)
        {
                  using (var context = new ShopContext()){

                var player = context.players.Where( i => i.Name.ToLower().Contains(name.ToLower())).ToList();

                return player;
            }
        }

        
    }
}