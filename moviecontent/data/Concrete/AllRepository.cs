using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class AllRepository<Tentity, TContext> : IRepository<Tentity>
    where Tentity:class
    where TContext:DbContext,new()
    {
        public List<Tentity> GetAll()
        {
            using(var context = new TContext()){

                return context.Set<Tentity>().ToList();

            }
        }

        public Tentity GetByID(int id)
        {

              using(var context = new TContext()){

                return context.Set<Tentity>().Find(id);

            }
            

        }
    }
}