using entity;
using data.Abstract;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace data.Concrete
{
    public class CategoryRepository : AllRepository<Category, ShopContext>, ICategoryRepository
    {
        public List<Category> GetCategoryLimit4()
        {
                using (var context = new ShopContext()){

                var category = context.categories.Include(i => i.movies).ThenInclude(i => i.movie).ToList();

                return category;
            }
        }

        public Category GetCategoryWithIdInclude(int id)
        {
            using (var context = new ShopContext()){

                var category = context.categories.Where(i => i.CategoryId == id).Include(i => i.movies).ThenInclude(i => i.movie).FirstOrDefault();

                return category;
            }
            {
                
            }
        }

        public List<Category> searchCat(string name)
        {
                  using (var context = new ShopContext()){

                var category = context.categories.Where( i => i.CategoryName.ToLower().Contains(name.ToLower())).ToList();

                return category;
            }
        }
    }
}