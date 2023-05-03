using SuperZapatos.Application.BaseEntity;
using SuperZapatos.Domain.Models;

namespace SuperZapatos.Application.Interfaces
{
    public interface IArticlesApplication
    {
        Task<BaseResponse<IEnumerable<Articles>>> GetAllArticles();
        Task<BaseResponse<Articles>> ArticleById(int articleId);
        Task<BaseResponse<bool>> RegisterArticle(Articles article);
        Task<BaseResponse<bool>> EditArticle(int articleId, Articles article);
        Task<BaseResponse<bool>> RemoveArticle(int articleId);
        Task<BaseResponse<IEnumerable<Articles>>> GetArticlesByStoreId(int storeId);
    }
}
