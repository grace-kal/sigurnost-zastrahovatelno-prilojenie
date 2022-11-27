using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services.Interfaces
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticles();
        Task<List<Article>> GetArticlesByAgentId(string agentId);
        Task CreateArticle(Article model);
        Task EditArticle(Article model);
        Task DeleteArticle(Article model);
        Task<Article> GetArticleById(int articleId);
    }
}
