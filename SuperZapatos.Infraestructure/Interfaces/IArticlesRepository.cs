using SuperZapatos.Domain.Models;

namespace SuperZapatos.Infraestructure.Interfaces
{
    public interface IArticlesRepository:IGenericRepository<Articles>
    {
        Task<IEnumerable<Articles>> GetArticlesByStoreId(int storeId);
    }
}
