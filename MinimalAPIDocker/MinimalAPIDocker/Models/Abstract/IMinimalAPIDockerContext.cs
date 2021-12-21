using MinimalAPIDocker.Models.Concrete;
using MongoDB.Driver;

namespace MinimalAPIDocker.Models.Abstract
{
    public interface IMinimalAPIDockerContext
    {
       IMongoCollection<Todo> Todos { get; }
    }
}
