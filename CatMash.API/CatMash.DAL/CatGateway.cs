using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace CatMash.DAL
{
    public class CatGateway
    {
        private readonly string _connectionString = "Server=.\\SQLEXPRESS;Database=CatMash;Trusted_Connection=True;";


        /// <summary>
        /// Retourne une liste de CatData qui contient les ID et Scores de tout les chats
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CatData>> GetLeaderBoard()
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var data = await con.QueryAsync<CatData>(
                    "select c.CatId, c.CatScore from cm.tCat c");
                return data;
            }
        }

        /// <summary>
        /// Incrémente le score du chat passé en argument
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public async Task<Result> IncrementScore(int catId)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                await con.ExecuteAsync(
                    "cm.sCatUpdate",
                    new { CatId = catId, CatScore = 1 },
                    commandType: CommandType.StoredProcedure);
                return Result.Success();
            }
        }
    }
}
