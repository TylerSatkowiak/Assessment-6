using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment6View.Models;
using System.Reflection.PortableExecutable;
using Assessment6.wwwroot;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using Newtonsoft.Json;

namespace Assessment6View.Controllers
{
    [Route("Character")]
    [ApiController]
    [Table("Character")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Character> Q = Character.Read();
            return View(Q);
        }

        [HttpPost]
       public IActionResult Create(string name, Character character)
        {
            Assessment6.User.Create(name, character.CharacterID, character);

            return View();
        }

        public IActionResult Test()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://anapioficeandfire.com/");
            var response = client.GetAsync($"api/characters/");
            return View("View This", response);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
