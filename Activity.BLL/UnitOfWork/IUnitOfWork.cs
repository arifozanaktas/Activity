﻿using Activity.BLL.Repository;
using Activity.DAL.ORM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.BLL
{
    public interface IUnitOfWork
    {
        public GenericRepository<User> UserRepository { get; }
        public GenericRepository<Category> CategoryRepository { get; }
        public GenericRepository<Activity.DAL.ORM.Activity> ActivityRepository { get; }

        public GenericRepository<Blog> BlogRepository { get; }
        public GenericRepository<Product> ProductRepository { get; }
        void Save();
    }
}
