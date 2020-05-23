using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Models;

namespace Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle { JobTitleId = 1, JobName = "актер" },
                new JobTitle { JobTitleId = 2, JobName = "режиссер" },
                new JobTitle { JobTitleId = 3, JobName = "сценарист"},
                new JobTitle { JobTitleId = 4, JobName = "продюсер" },
                new JobTitle { JobTitleId = 5, JobName = "оператор" },
                new JobTitle { JobTitleId = 6, JobName = "композитор" });

            modelBuilder.Entity<Celebrity>().HasData(
                
                new Celebrity
                {
                    CelebrityId = -1,
                    FirstName = "Хью",
                    LastName = "Джекман",
                    CountViews = 134000,
                    ImageSource = "StaticFiles/images/1.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -2,
                    FirstName = "Райан",
                    LastName = "Рейнольдс",
                    CountViews = 127000,
                    ImageSource = "StaticFiles/images/2.jpg"

                },new Celebrity
                {
                    CelebrityId = -3,
                    FirstName = "Роберт",
                    LastName = "Дауни (младший)",
                    CountViews = 126000,
                    ImageSource = "StaticFiles/images/3.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -4,
                    FirstName = "Уилл",
                    LastName = "Смит",
                    CountViews = 121000,
                    ImageSource = "StaticFiles/images/4.jpg",
                },
                
                new Celebrity
                {
                    CelebrityId = -5,
                    FirstName = "Брэд",
                    LastName = "Питт",
                    CountViews = 120500,
                    ImageSource = "StaticFiles/images/5.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -6,
                    FirstName = "Леонардо",
                    LastName = "Ди Каприо",
                    CountViews = 120000,
                    ImageSource = "StaticFiles/images/6.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -7,
                    FirstName = "Натали",
                    LastName = "Портман",
                    CountViews = 91000,
                    ImageSource = "StaticFiles/images/7.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -8,
                    FirstName = "Роджер",
                    LastName = "Дикинс",
                    CountViews = 20000,
                    ImageSource = "StaticFiles/images/8.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -9,
                    FirstName = "Ханс",
                    LastName = "Циммер",
                    CountViews = 50000,
                    ImageSource = "StaticFiles/images/9.jpg"
                },
                new Celebrity
                {
                    CelebrityId = -10,
                    FirstName = "Квентин",
                    LastName = "Тарантино",
                    CountViews = 95000,
                    ImageSource = "StaticFiles/images/10.jpg"
                });

            modelBuilder.Entity<CelebrityJobTitles>().HasData(
                new CelebrityJobTitles { CelebrityId = -1, JobTitleId = 1 },

                new CelebrityJobTitles { CelebrityId = -2, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -2, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -3, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -3, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -4, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -4, JobTitleId = 2 },
                new CelebrityJobTitles { CelebrityId = -4, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -5, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -5, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -6, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -6, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -7, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -7, JobTitleId = 2 },
                new CelebrityJobTitles { CelebrityId = -7, JobTitleId = 3 },
                new CelebrityJobTitles { CelebrityId = -7, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -8, JobTitleId = 5 },

                new CelebrityJobTitles { CelebrityId = -9, JobTitleId = 6 },

                new CelebrityJobTitles { CelebrityId = -10, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -10, JobTitleId = 2 },
                new CelebrityJobTitles { CelebrityId = -10, JobTitleId = 3 },
                new CelebrityJobTitles { CelebrityId = -10, JobTitleId = 4 }
                );
        }
    }
}
