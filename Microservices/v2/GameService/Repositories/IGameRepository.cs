using v2.shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameService.Repositories
{
    public interface IGameRepository
    {
    Task<Game> CreateAsync(Game c);
    Task<IEnumerable<Game>> RetrieveAllAsync();
    Task<Game> RetrieveAsync(int id);
    Task<Game> UpdateAsync(int id, Game c);
    Task<bool?> DeleteAsync(int id);
    }
}