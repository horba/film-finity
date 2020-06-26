﻿using AutoMapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Serial, SerialDTO>()
                .ForMember(dto => dto.Celebrities, opt => opt.MapFrom(
                    route => route.SerialCelebrity.ToList().Select(
                        el => new CelebrityDTO {
                            CelebrityId = el.Celebrity.CelebrityId,
                            FirstName = el.Celebrity.FirstName,
                            LastName = el.Celebrity.LastName,
                            CountViews = el.Celebrity.CountViews,
                            ImageSource = el.Celebrity.ImageSource,
                            JobTitles = el.Celebrity.CelebrityJobTitles.Select(g => g.JobTitle).Select(g => new JobTitleDTO
                            { JobTitleId = g.JobTitleId, JobName = g.JobName }).ToList()
                        })
                    )
                )
                .ForMember(dto => dto.GenreTitles, opt => opt.MapFrom(
                    route => route.SerialGenreTitles.ToList().Select(
                        el => new GenreDTO { Id = el.GenreTitle.Id, Name = el.GenreTitle.Name })
                    )
                );
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