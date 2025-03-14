﻿using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserWithPostAsync(int id);
    }
}
