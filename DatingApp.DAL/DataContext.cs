using DatingApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatingApp.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
