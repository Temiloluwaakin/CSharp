using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _context;


        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }


        //public async Task<User> GetUserWithPostsAsync(int id)
        //{
        //    return await _context.Users
        //        .Include(u => u.Post) // Ensure posts are included
        //        .FirstOrDefaultAsync(u => u.Id == id);
        //}

        public async Task<User> GetUserWithPostAsync(int id)
        {
            return await _context.Users
                .Include(u => u.Post) // Ensure posts are included
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
