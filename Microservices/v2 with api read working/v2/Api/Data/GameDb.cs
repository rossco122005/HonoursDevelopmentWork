using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
    public class GameDb : DbContext
    {
        public DbSet<Game> Games{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            string CurrentDir = System.Environment.CurrentDirectory;
            string ParentDir = System.IO.Directory.GetParent(CurrentDir).FullName;
            string path = System.IO.Path.Combine(ParentDir, "MvcGame.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}