using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using WebAPI.DTO;
namespace WebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<News, NewsDTO>()
                .ForMember(dto => dto.Author, opt => opt.MapFrom(
                    route => new NewsAuthorDTO { Id = route.Author.Id, FirstName = route.Author.FirstName, LastName = route.Author.LastName })
                )
                .ForMember(dto => dto.Categories, opt => opt.MapFrom(
                    route => route.NewsCategories.ToList().Select
                    (el => new NewsCategoryDTO { Id = el.Category.Id, Name = el.Category.Name }))
                );
        }
    }
}
