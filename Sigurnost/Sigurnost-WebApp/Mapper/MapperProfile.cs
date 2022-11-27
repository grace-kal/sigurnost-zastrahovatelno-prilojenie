using AutoMapper;
using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigurnost_WebApp.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Article
            CreateMap<Article, Article>();
            CreateMap<List<Article>, List<Article>>();
        }
        
    }
}
