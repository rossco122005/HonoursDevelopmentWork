using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using v2.shared;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace GameConsume.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            HttpResponseMessage response = await client.GetAsync("Games");
            string jsonString = await response.Content.ReadAsStringAsync();
            IEnumerable<Game> model = JsonConvert.DeserializeObject<IEnumerable<Game>>(jsonString);
            return View(model);        
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            HttpResponseMessage response = await client.GetAsync("Games/" + id);
            string jsonString = await response.Content.ReadAsStringAsync();
            Game model = JsonConvert.DeserializeObject<Game>(jsonString);
            return View(model);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            HttpResponseMessage response = await client.GetAsync("Games/" + id);
            string jsonString = await response.Content.ReadAsStringAsync();
            Game model = JsonConvert.DeserializeObject<Game>(jsonString);
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            HttpResponseMessage response = await client.GetAsync("Games/" + id);
            string jsonString = await response.Content.ReadAsStringAsync();
            Game model = JsonConvert.DeserializeObject<Game>(jsonString);
            return View(model);
        }

        // GET: Games/CreateTest
        public IActionResult CreateTest()
        {
            return View();
        }

        // GET: Games/EditTest
        public IActionResult EditTest()
        {
            return View();
        }

        // GET: Games/DeleteTest
        public async Task<IActionResult> DeleteTest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            HttpResponseMessage response = await client.GetAsync("Games");
            string jsonString = await response.Content.ReadAsStringAsync();
            IEnumerable<Game> models = JsonConvert.DeserializeObject<IEnumerable<Game>>(jsonString);
            Game model = new Game();
            model = models.Last();
            return View(model);
        }
    }
}