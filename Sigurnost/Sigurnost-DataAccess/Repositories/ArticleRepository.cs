using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sigurnost_DataAccess.Repositories.Interfaces;
using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_DataAccess.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly SigurnostDbContext _dbContext;
        public ArticleRepository(SigurnostDbContext dbContext)
        {
            _dbContext = dbContext;
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
            return await _dbContext.Articles.ToListAsync();
        }

        public async Task<List<Article>> GetArticlesByAgentId(string agentId)
        {
            return await _dbContext.Articles.Where(a => a.AuthorId == Guid.Parse(agentId)).ToListAsync();
        }

        public async Task<Article> GetArticleById(int articleId)
{
            return await _dbContext.Articles.FirstOrDefaultAsync(a => a.ArticleId == articleId);
        }
    }
}
