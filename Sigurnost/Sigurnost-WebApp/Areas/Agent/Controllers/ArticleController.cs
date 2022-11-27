using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sigurnost_Services.Interfaces;
using Sigurnost_WebApp.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Sigurnost_WebApp.Areas.Agent.Controllers
{
    [Authorize(Roles = "Agent")]
    [Route("[Area]/[Controller]/[Action]")]
    [Area("Agent")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public ArticleController(IArticleService articleService, IMapper mapper,IUserService userService)
        {
            _articleService = articleService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var recieved= await _articleService.GetAllArticles();
            ListArticlesVM articles = _mapper.Map<ListArticlesVM>(recieved);
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> GetMyArticles()
        {
            var user = await _userService.GetUserByUsername(User.Identity.Name);
            var recieved = await _articleService.GetArticlesByAgentId(user.Id);
            ListArticlesVM articles = _mapper.Map<ListArticlesVM>(recieved);
            return View(articles);
        }

    }
}
