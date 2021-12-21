using MinimalAPIDocker.Config;
using MinimalAPIDocker.Models.Abstract;
using MongoDB.Driver;

namespace MinimalAPIDocker.Models.Concrete
{
    public class MinimalAPIDockerContext:IMinimalAPIDockerContext
    {
        private readonly IMongoDatabase _db;

        public MinimalAPIDockerContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }

        public IMongoCollection<Todo> Todos => _db.GetCollection<Todo>("Todos");

    }
}
