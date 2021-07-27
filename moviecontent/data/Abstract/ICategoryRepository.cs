using System.Collections.Generic;
using entity;

namespace data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
         public Category GetCategoryWithIdInclude(int id);

         public List<Category> GetCategoryLimit4();

         public List<Category> searchCat(string name);
    }
}