using Microsoft.EntityFrameworkCore;
using MvcGame.Models;

namespace MvcGame.Data
{
    public class MvcGameContext : DbContext
    {
        public MvcGameContext (DbContextOptions<MvcGameContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}