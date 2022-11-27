using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sigurnost_Services.Interfaces;
using Sigurnost_WebApp.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigurnost_WebApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var recieved = await _articleService.GetAllArticles();
            ListArticlesVM articles = _mapper.Map<ListArticlesVM>(recieved);
            return View(articles);
        }


    }
}
