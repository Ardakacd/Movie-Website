using System.Collections.Generic;
using entity;
namespace data.Abstract
{
    
    public interface IRepository<T>
    {

        List<T> GetAll();

        T GetByID(int id);
         
    }
}