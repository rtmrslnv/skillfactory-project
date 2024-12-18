﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwesomeNetwork.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
