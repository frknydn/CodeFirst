using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly MeetingDbContext _meetingDbContext;
        private DbSet<T> _table;

        public BaseRepository(MeetingDbContext meetingDbContext)
        {
            _meetingDbContext = meetingDbContext;
        }
        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;
            
        }

        public int Save()
        {
            return _meetingDbContext.SaveChanges();
        }
    }
}
