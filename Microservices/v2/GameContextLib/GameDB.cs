using System;
using Microsoft.EntityFrameworkCore;

namespace v2.shared
{
    public class GameDB  : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GameDB(DbContextOptions<GameDB> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){}
    }
}
