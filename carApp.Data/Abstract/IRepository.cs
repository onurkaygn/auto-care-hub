﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace carApp.Data.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T,bool>> expression); //repository.GetAll(x => x.Price > 100); ====> using for linq expressions like this.

        T Get(Expression<Func<T,bool>> expression);

        T Find(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int Save();

        //Async Methods

        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);

        Task<List<T>> GetAllAsync();

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);    
        Task<int> SaveAsync();




    }
}
