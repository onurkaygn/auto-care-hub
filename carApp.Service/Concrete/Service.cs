using carApp.Data;
using carApp.Data.Abstract;
using carApp.Data.Concrete;
using carApp.Entities;
using carApp.Service.Abstract;
using System.Linq.Expressions;

namespace carApp.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context) { }
    }
}
