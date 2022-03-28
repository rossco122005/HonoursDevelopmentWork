using Microsoft.EntityFrameworkCore.ChangeTracking;
using v2.shared;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace GameService.Repositories
{
    public class GameRepository : IGameRepository
    {
        //use a static thread-safe dictionary field to cache the Games
        private static ConcurrentDictionary <int, Game> gamesCache;

        //use an instance data context field because it should not be 
        //cached due to their internal caching
        private GameDB db;

        public GameRepository(GameDB db)
        {
            this.db = db;
            //pre-load Games from database as a normal
            //dictionary with GameID as the key,
            //then convert to a thread-safe ConcurrentDictionary
            if(gamesCache == null)
            {
                gamesCache = new ConcurrentDictionary<int, Game>(db.Games.ToDictionary(c => c.GameID));
            }
        }

        public async Task<Game> CreateAsync(Game c)
        {
            //normalize GameID into uppercase
            //c.GameID = c.GameID.ToUpper();
            //add to database using EF Core
            EntityEntry<Game> added = await db.Games.AddAsync(c);
            int affected = await db.SaveChangesAsync();
            if(affected == 1)
            {
                //if the Game is new, add it to cache, else
                //call UpdateCache method
                return gamesCache.AddOrUpdate(c.GameID, c, UpdateCache);
            }
            else
            {
                return null;
            } 
        }

        public Task<IEnumerable<Game>> RetrieveAllAsync()
        {
            //for performance, get from cache
            return Task.Run<IEnumerable<Game>>(() => gamesCache.Values);
        }

        public Task<Game> RetrieveAsync(int id)
        {
            return Task.Run( () =>
            {
                //for performance, get from cache
                //id = id.ToUpper();
                Game c;
                gamesCache.TryGetValue(id, out c);
                return c;
            });
        }

        private Game UpdateCache(int id, Game c)
        {
            Game old;
            if(gamesCache.TryGetValue(id, out old))
            {
                if(gamesCache.TryUpdate(id, c, old))
                {
                    return c;
                }
            }
            return null;
        }

        public async Task<Game> UpdateAsync(int id, Game c)
        {
            //normalize Game ID
            //id = id.ToUpper();
            //c.GameID = c.GameID.ToUpper();
            //update in database
            db.Games.Update(c);
            int affected = await db.SaveChangesAsync();
            if(affected == 1)
            {
                //update in cache
                return UpdateCache(id, c);
            }
            return null;
        }

        public async Task<bool?> DeleteAsync(int id)
        {
            //id = id.ToUpper();
            //remove from database
            Game c = db.Games.Find(id);
            db.Games.Remove(c);
            int affected = await db.SaveChangesAsync();
            if(affected == 1)
            {
                //remove from cache
                return gamesCache.TryRemove(id, out c);
            }
            else
            {
                return null;
            }
        }
    }
}