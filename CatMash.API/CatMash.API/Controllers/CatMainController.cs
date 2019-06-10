using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatMash.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CatMash.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatMainController : ControllerBase
    {
        CatGateway catGateway;

        public CatMainController()
        {
            catGateway = new CatGateway();
        }

        // GET CatMain/vote/
        [HttpPost("{id}/vote")]
        public Task<Result> Vote(int id)
        {
            return catGateway.IncrementScore(id);
        }

        // GET CatMain/leaderboard/
        [HttpGet("leaderboard")]
        public async Task<IEnumerable<CatData>> GetLeaderBoard()
        {
            var test = (List<CatData>)await catGateway.GetLeaderBoard();
            return (List<CatData>)await catGateway.GetLeaderBoard();
        } 
    }
}
