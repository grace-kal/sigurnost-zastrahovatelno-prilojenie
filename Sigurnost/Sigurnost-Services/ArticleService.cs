using Sigurnost_DataAccess.Repositories.Interfaces;
using Sigurnost_Models;
using Sigurnost_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepo;
        public ArticleService(IArticleRepository articleRepo)
        {
            _articleRepo = articleRepo;
        }
        public async Task CreateArticle(Article model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteArticle(Article model)
        {
            throw new NotImplementedException();
        }

        public async Task EditArticle(Article model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> GetAllArticles()
        {
            return await _articleRepo.GetAllArticles();
        }

        public async Task<List<Article>> GetArticlesByAgentId(string agentId)
        {
            return await _articleRepo.GetArticlesByAgentId(agentId);
        }
        
        public async Task<Article> GetArticleById(int articleId)
        {
            return await _articleRepo.GetArticleById(articleId);
        }
    }
}
