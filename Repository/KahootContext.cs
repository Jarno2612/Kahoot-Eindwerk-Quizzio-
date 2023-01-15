using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class KahootContext : DbContext
    {
        public KahootContext(DbContextOptions<KahootContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
        }
        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<UserGame> UserGame { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}
