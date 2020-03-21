using System.Collections.Generic;
using GraphQL;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace AZApi
{
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().SingleOrDefault(j => j.Id == id);
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "World";
        }

        [GraphQLMetadata("planets")]
        public async Task<List<Planet>> GetPlanet()
        {
            var planets = await Fetch.ByUrl("planets/");
            var result = JsonConvert.DeserializeObject<Result<List<Planet>>>(planets);
            return result.results;
        }
    }

    public class Result<T>
    {
        public int count { get; set; }
        public T results { get; set; }
    }
    public class Planet
    {
        public string Name { get; set; }
    }
}
