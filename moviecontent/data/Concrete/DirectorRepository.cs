using entity;
using  data.Abstract;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace data.Concrete
{
    public class DirectorRepository : AllRepository<Director, ShopContext>, IDirectorRepository
    {
        public Director getDirectorInclude(int id)
        {
            using(var context = new ShopContext()){
                var director = context.directors.Where(i => id == i.DirectorId).Include(i => i.movies).FirstOrDefault();

                return director;
            }
        }

         public List<Director> searchDir(string name)
        {
                  using (var context = new ShopContext()){

                var director = context.directors.Where( i => i.Name.ToLower().Contains(name.ToLower())).ToList();

                return director;
            }
        }
    }
}