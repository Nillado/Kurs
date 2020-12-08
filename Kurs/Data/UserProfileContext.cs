using Kurs.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Data
{
    public class UserProfileContext : DbContext
    {
        public static UserProfile MockUserProfile { get; } = new UserProfile()
        {
            Nickname = "Nillado",
            Email = "nillado@dgva.com",
            Password = "qwerty"
        };
        public DbSet<UserProfile> Users { get; set; }
        public UserProfileContext(DbContextOptions<UserProfileContext> options) : base(options)
        {
            Database.EnsureCreated();
            if (!Users.Any())
            {
                Users.Add(MockUserProfile);
            }
            SaveChanges();
        }
    }
}
