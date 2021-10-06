using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomCatController : ControllerBase
    {
        private static readonly string[] data = new[]
        {
            "https://cdn2.thecatapi.com/images/MTg1NjQwNw.jpg", "https://cdn2.thecatapi.com/images/35m.jpg", "https://cdn2.thecatapi.com/images/UOX__3Q-5.png", "https://cdn2.thecatapi.com/images/AYKPpFa21.jpg", "https://cdn2.thecatapi.com/images/7d3.jpg",
            "https://cdn2.thecatapi.com/images/NAuyH-ZBq.jpg", "https://cdn2.thecatapi.com/images/MTY3ODg2Mw.jpg", "https://cdn2.thecatapi.com/images/KClekopiu.jpg" , "https://cdn2.thecatapi.com/images/d6v.jpg"
        };

        private readonly ILogger<RandomCatController> _logger;

        public RandomCatController(ILogger<RandomCatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<RandomCat> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new RandomCat
            {
                Width = rng.Next(600,1000),
                Height = rng.Next(500, 750),
                Url = data[rng.Next(data.Length)]
            })
            .ToArray();
        }
    }
}
