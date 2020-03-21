using GraphQL;

namespace AZApi
{
    public class Mutation
    {
        [GraphQLMetadata("addJedi")]
        public Jedi AddJedi(Jedi input)
        {
            return StarWarsDB.AddJedi(input);
        }

        [GraphQLMetadata("updateJedi")]
        public Jedi UpdateJedi(Jedi input)
        {
            return StarWarsDB.UpdateJedi(input);
        }

        [GraphQLMetadata("removeJedi")]
        public string RemoveJedi(int id)
        {
            return StarWarsDB.RemoveJedi(id);
        }
    }
}
