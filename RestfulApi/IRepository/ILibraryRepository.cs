using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulApi.IRepository
{
   public interface ILibraryRepository<T>  
{  
    IEnumerable<T> GetAllAuthor();
} 
}
    