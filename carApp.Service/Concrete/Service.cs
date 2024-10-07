using carApp.Data.Abstract;
using carApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp.Service.Concrete
{
    public class Service<T> : Repository<T> where T : class, IEntity, new()
    {
    }
}
