using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    //DbContext uses Microsoft Entity FrameWork Core
    //it is used to talk wit the database Tables
    public class AppDbContext : DbContext
    {

        //these allows you to configure the database provider PostgreSQL and connection string.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        //these DbSet<Post> and the other reps the tables in the db
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)          // A BlogPost has one User
                .WithMany(u => u.Post)    // A User has many BlogPosts
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)       // A Comment belongs to one BlogPost
                .WithMany(p => p.Comments)     // A BlogPost has many Comments
                .HasForeignKey(c => c.PostId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)           // A Comment has one User (Author)
                .WithMany(u => u.Comments)      // A User has many Comments
                .HasForeignKey(c => c.UserId);
        }
    }
}
