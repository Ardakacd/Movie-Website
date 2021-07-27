
using System.Collections.Generic;
using entity;
namespace data.Abstract
{
    public interface IDirectorRepository:IRepository<Director>
    {


     public Director getDirectorInclude(int id);  

     public List<Director> searchDir(string name);  
    }
}