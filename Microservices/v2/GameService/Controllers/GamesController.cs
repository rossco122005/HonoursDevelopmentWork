using Microsoft.AspNetCore.Mvc;
using v2.shared;
using GameService.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace GameService.Controllers
{
    // base address: api/games
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameRepository repo;
        // constructor injects repository registered in Startup
        public GamesController(IGameRepository repo)
        {
            this.repo = repo;
        }

        //GET: api/games
        //GET: api/games/?game=[game]
        //this will always return a list of games even if it's empty
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Game>))]
        public async Task<IEnumerable<Game>> GetGames(string releaseYear)
        {
            if(string.IsNullOrWhiteSpace(releaseYear))
            {
                return await repo.RetrieveAllAsync();
            }
            else
            {
                return (await repo.RetrieveAllAsync()).Where(game => game.ReleaseYear == releaseYear);
            }
        }

        //GET: api/games/[id]
        [HttpGet("{id}", Name = nameof(GetGames))]//named route
        [ProducesResponseType(200, Type = typeof(Game))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetGame(int id)
        {
            Game c = await repo.RetrieveAsync(id);
            if(c == null)
            {
                return NotFound(); //404 resource not found
            }
            return Ok(c); //200 OK with customer in body
        }

        //POST: api/games
        //BODY: Game(JSON, XML)
        [HttpPost]
        [ProducesResponseType(201, Type = typeof(Game))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Game c)
        {
            if(c == null)
            {
                return BadRequest(); //400 Bad request
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 Bad request
            }

            Game added = await repo.CreateAsync(c);
            return CreatedAtRoute(//201 Created
                routeName: nameof(GetGame),
                routeValues: new{id = added.GameID},
                value: added);
        }

        //PUT: api/games/[id]
        //BODY: Game(JSON, XML)
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] Game c)
        {
            if(c == null || c.GameID != id)
            {
                return BadRequest();// 400 Bad request
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);// 400 Bad request
            }
            var existing = await repo.RetrieveAsync(id);
            if(existing == null)
            {
                return NotFound();
            }
            await repo.UpdateAsync(id, c); // 404 resource not found
            return new NoContentResult();//204 No content
        }

        //DELETE: api/game/[id]
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delte(int id)
        {
            var existing = await repo.RetrieveAsync(id);
            if(existing == null)
            {
                return NotFound(); //404 Resource not found
            }
            bool? deleted = await repo.DeleteAsync(id);
            if(deleted.HasValue && deleted.Value)//short circuit AND
            {
                return new NoContentResult();//204 No content
            }
            else
            {
                return BadRequest(//400 Bad request
                    $"Game {id} was found but failed to delete.");
            }
        }
    }
}