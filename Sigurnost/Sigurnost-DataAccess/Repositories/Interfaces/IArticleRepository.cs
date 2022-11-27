using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Repositories.Interfaces
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticles();
        Task<List<Article>> GetArticlesByAgentId(string agentId);
        Task CreateArticle(Article model);
        Task EditArticle(Article model);
        Task DeleteArticle(Article model);
        Task<Article> GetArticleById(int articleId);
    }
}
