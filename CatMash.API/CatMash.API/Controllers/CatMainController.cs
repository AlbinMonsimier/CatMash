using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CatMash.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CatMash.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatMainController : ControllerBase
    {
        CatGateway CatGateway;

        public CatMainController()
        {
            CatGateway = new CatGateway();
        }

        // GET CatMain/vote/
        [HttpPost("{id}/vote")]
        public Task<Result> Vote(int id)
        {
            return CatGateway.IncrementScore(id);
        }

        [HttpGet("catsJSON")]
        public async Task<CatJsonData> GetCatsJSON()
        {
            using (StreamReader r = new StreamReader(@"Ressources\cats.json"))
            {
                string json = r.ReadToEnd();
                var a = JsonConvert.DeserializeObject<CatJsonData>(json);
                return a;
            }
        }

        // GET CatMain/leaderboard/
        [HttpGet("leaderboard")]
        public async Task<IEnumerable<CatData>> GetLeaderBoard()
        {
            var test = (List<CatData>)await CatGateway.GetLeaderBoard();
            return (List<CatData>)await CatGateway.GetLeaderBoard();
        } 
    }
}
