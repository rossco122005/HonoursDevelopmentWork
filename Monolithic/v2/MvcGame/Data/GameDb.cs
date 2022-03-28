using Microsoft.EntityFrameworkCore;
using MvcGame.Models;

namespace MvcGame.Data
{
    public class GameDb : DbContext
    {
        public DbSet<Game> Game{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            string CurrentDir = System.Environment.CurrentDirectory;
            string ParentDir = System.IO.Directory.GetParent(CurrentDir).FullName;
            string path = System.IO.Path.Combine(ParentDir, "MvcGame.db");
            optionsBuilder.UseSqlite($"filename={path}");
        }
    }
}