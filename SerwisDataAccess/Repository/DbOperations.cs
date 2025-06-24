using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace SerwisDataAccess.Repository
{
    public class DbOperations<T> : IDbOperations<T> where T : class
    {
        private readonly ApplicationDbContext _db;
   
        public DbOperations(ApplicationDbContext db)
        {
            _db = db;        
        }

        public void AddRequest(T request)
        {
           _db.Add(request);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
