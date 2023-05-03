using SuperZapatos.Application.BaseEntity;
using SuperZapatos.Application.Interfaces;
using SuperZapatos.Domain.Models;
using SuperZapatos.Infraestructure.Interfaces;
using SuperZapatos.Utilities;

namespace SuperZapatos.Application.Services
{
    public class ArticlesApplication : IArticlesApplication
    {
        private readonly IArticlesRepository _articlesRepository;
        public ArticlesApplication(IArticlesRepository articlesRepository) 
        {
            _articlesRepository = articlesRepository;
        }

        public async Task<BaseResponse<Articles>> ArticleById(int articleId)
        {
            var response = new BaseResponse<Articles>() { TotalElements=0 };
            var article = await _articlesRepository.GetByIdAsync(articleId);
            if (article is not null)
            {
                response.Success = true;
                response.Data = article;
                response.Message = ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode =(int) EErrorCode.NoContent;
            }
            return response;
        }

        public async Task<BaseResponse<IEnumerable<Articles>>> GetAllArticles()
        {
            var response = new BaseResponse<IEnumerable<Articles>>() { TotalElements=0 };
            var articlesList = await _articlesRepository.GetAllAsync();
            if (articlesList is not null)
            {
                response.Success = true;
                response.Data = articlesList;
                response.Message = ReplyMessage.MESSAGE_QUERY;
                response.TotalElements = articlesList.Count();
                if(articlesList.Count()==0)
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
            }
            else
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
            }
            return response;
        }

        public async Task<BaseResponse<bool>> RegisterArticle(Articles article)
        {
            var response = new BaseResponse<bool>();
            try
            {
                response.Data = await _articlesRepository.RegisterAsync(article);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_SAVE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.NoContent;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }
            
            return response;
        }

        public async Task<BaseResponse<bool>> EditArticle(int articleId, Articles article)
        {
            var response = new BaseResponse<bool>();
            var articleEdit = await ArticleById(articleId);
            if (articleEdit.Data is null)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.InputError;
                return response;
            }
            try
            {
                article.Id = articleId;
                response.Data = await _articlesRepository.EditAsync(article);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_UPDATE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.InternalError;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }
            
            return response;
        }

        public async Task<BaseResponse<bool>> RemoveArticle(int articleId)
        {
            var response = new BaseResponse<bool>();
            var articleDelete = await ArticleById(articleId);
            if (articleDelete.Data is null)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
                return response;
            }
            try
            {
                response.Data = await _articlesRepository.RemoveAsync(articleId);
                if (response.Data)
                {
                    response.Success = true;
                    response.Message = ReplyMessage.MESSAGE_DELETE;
                }
                else
                {
                    response.Success = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                    response.errorCode = (int)EErrorCode.NoContent;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_FAILED;
                response.errorCode = (int)EErrorCode.InternalError;
            }
            
            return response;
        }

        public async Task<BaseResponse<IEnumerable<Articles>>> GetArticlesByStoreId(int storeId)
        {
            var response = new BaseResponse<IEnumerable<Articles>>() { TotalElements = 0 };
            var articles = await _articlesRepository.GetArticlesByStoreId(storeId);
            if (articles is not null)
            {
                response.Success = true;
                response.Data = articles;
                response.Message = ReplyMessage.MESSAGE_QUERY;
                response.TotalElements = articles.Count();
            }
            else
            {
                response.Success = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                response.errorCode = (int)EErrorCode.NoContent;
            }
            return response;
        }
    }
}
