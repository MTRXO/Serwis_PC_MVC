using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerwisDataAccess.Repository
{
    public interface IDbOperations<T> where T : class
    {
        void AddRequest(T request);
        void SaveChanges();
    }
}
