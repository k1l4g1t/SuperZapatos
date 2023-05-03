using Microsoft.AspNetCore.Mvc;
using SuperZapatos.Application.Interfaces;
using SuperZapatos.Domain.Models;

namespace SuperZapatos.API.Controllers
{
    [Route("services/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesApplication _articlesApplication;

        public ArticlesController(IArticlesApplication articlesApplication)
        {
            _articlesApplication = articlesApplication;
        }

        [HttpGet("stores/{storeId:int}")]
        public async Task<IActionResult> GetArticlesByStoreId(int storeId)
        {
            var response = await _articlesApplication.GetArticlesByStoreId(storeId);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var response=await _articlesApplication.GetAllArticles();
            return Ok(response);
        }

        [HttpGet("{articleId:int}")]
        public async Task<IActionResult> ArticleById(int articleId)
        {
            var response = await _articlesApplication.ArticleById(articleId);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterArticle([FromBody] Articles article)
        {
            var response = await _articlesApplication.RegisterArticle(article);
            return Ok(response);
        }

        [HttpPut("{articleId:int}")]
        public async Task<IActionResult> EditArticle(int articleId, [FromBody] Articles article)
        {
            var response = await _articlesApplication.EditArticle(articleId,article);
            return Ok(response);
        }

        [HttpDelete("{articleId:int}")]
        public async Task<IActionResult> DeleteArticle(int articleId)
        {
            var response = await _articlesApplication.RemoveArticle(articleId);
            return Ok(response);
        }

    }
}
