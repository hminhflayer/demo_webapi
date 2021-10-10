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
            "https://cdn2.thecatapi.com/images/NAuyH-ZBq.jpg", "https://cdn2.thecatapi.com/images/MTY3ODg2Mw.jpg", "https://cdn2.thecatapi.com/images/KClekopiu.jpg" , "https://cdn2.thecatapi.com/images/d6v.jpg",
            "https://1.bp.blogspot.com/-sn5m6XBixOk/XxVal_4gfgI/AAAAAAAAtHc/_0SJ056yuEoYmORpa64mWQGBQcjVCldngCLcBGAsYHQ/s1600/Meo-Ngau%2B%25281%2529.jpg", "https://1.bp.blogspot.com/-3qIVawuirDk/XxVamhXPSjI/AAAAAAAAtHk/VKQTTKP5mI4plvjRqbivtHO0A6NC8AWVgCLcBGAsYHQ/s1600/Meo-Ngau%2B%252812%2529.jpg", "https://1.bp.blogspot.com/-IR29N4DVtBY/XxVasXHvs0I/AAAAAAAAtJQ/8BhiBdPtTlY82LNF8SMiUW3NXGfJqQjEACLcBGAsYHQ/s1600/Meo-Ngau%2B%25287%2529.jpg", "https://1.bp.blogspot.com/-CQkoeY1q_bU/XxVanYJXjVI/AAAAAAAAtHw/HLdub7N6vIYpgXv0V12IaD6uZAuSyImOACLcBGAsYHQ/s1600/Meo-Ngau%2B%252815%2529.jpg", "https://1.bp.blogspot.com/-gefO7nDDwjg/XxVapRrxSTI/AAAAAAAAtIU/Q0Gto6w_BygskX1UEpf5Lj2ED0w1J5CdgCLcBGAsYHQ/s1600/Meo-Ngau%2B%252823%2529.jpg",
            "https://1.bp.blogspot.com/-DU57l41ulmc/XxVaqrdI6sI/AAAAAAAAtIw/VG6cCeEtsuk21bwFQY4eOEERhul5bHvggCLcBGAsYHQ/s1600/Meo-Ngau%2B%25283%2529.jpg", "https://1.bp.blogspot.com/-m4774BnKCOk/XxVanGD9M7I/AAAAAAAAtHs/izpi6oUBcLUry4Q9IhQGR_bPpBhmkuYrwCLcBGAsYHQ/s1600/Meo-Ngau%2B%252814%2529.jpg", "https://1.bp.blogspot.com/-N1R4k4Es-l4/XxVarVs0iZI/AAAAAAAAtJE/-XMzAvQUXVIJ2zaY0ggc7aQq03YcVPEAACLcBGAsYHQ/s1600/Meo-Ngau%2B%25284%2529.jpg" , "https://1.bp.blogspot.com/-uiiijLnEcys/XxVaofobT5I/AAAAAAAAtII/1XDvMES09qcHJY7wDvBlj_4yBN-F3woaACLcBGAsYHQ/s1600/Meo-Ngau%2B%252820%2529.jpg","https://www.takadada.com/wp-content/uploads/2019/07/hinh-anh-meo-con-dang-yeu-39.jpg"
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
