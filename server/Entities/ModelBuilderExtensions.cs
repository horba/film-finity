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
                new JobTitle { JobTitleId = 3, JobName = "сценарист" },
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

                }, new Celebrity
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
                    ImageSource = "StaticFiles/images/9.png"
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

            modelBuilder.Entity<Actor>().HasData(
               new Actor { ActorId = 1, ActorName = "Том Харпер" },
               new Actor { ActorId = 2, ActorName = "Филисити Джонс" },
               new Actor { ActorId = 3, ActorName = "Эдди Редмейн" },
               new Actor { ActorId = 4, ActorName = "Химет Патель" },
               new Actor { ActorId = 5, ActorName = "Режиссер" },
               new Actor { ActorId = 6, ActorName = "Джордж Маккей" },
               new Actor { ActorId = 7, ActorName = "Дин-Чарльз Чакман" },
               new Actor { ActorId = 8, ActorName = "Ричард Мэдден" },
               new Actor { ActorId = 9, ActorName = "Джордж Нолфи" },
               new Actor { ActorId = 10, ActorName = "Энтони Маки" },
               new Actor { ActorId = 11, ActorName = "Сэмюел Лерой Джексон" },
               new Actor { ActorId = 12, ActorName = "Ниа Лонг" },
               new Actor { ActorId = 13, ActorName = "Джейк Кэздан" },
               new Actor { ActorId = 14, ActorName = "Дуэйн Джонсон" },
               new Actor { ActorId = 15, ActorName = "Карен Гиллан" },
               new Actor { ActorId = 16, ActorName = "Джейк Блэк" },
               new Actor { ActorId = 17, ActorName = "Кевин Харт" },
               new Actor { ActorId = 18, ActorName = "Джефф Фаулер" },
               new Actor { ActorId = 19, ActorName = "Джим Керри" },
               new Actor { ActorId = 20, ActorName = "Джеймс Марсден" },
               new Actor { ActorId = 21, ActorName = "Тика Самптер" },
               new Actor { ActorId = 22, ActorName = "Бен Шварц" },
               new Actor { ActorId = 23, ActorName = "Мэти Янь" },
               new Actor { ActorId = 24, ActorName = "Марго Робби" },
               new Actor { ActorId = 25, ActorName = "Джерни Смоллет-Белл" },
               new Actor { ActorId = 26, ActorName = "Мэри Элизабет Уинстэд" },
               new Actor { ActorId = 27, ActorName = "Грета Гервич" },
               new Actor { ActorId = 28, ActorName = "Сирта Ронан" },
               new Actor { ActorId = 29, ActorName = "Тимоти Шаламе" },
               new Actor { ActorId = 30, ActorName = "Флоренс Пью" },
               new Actor { ActorId = 31, ActorName = "Эмма Уотсон" },
               new Actor { ActorId = 32, ActorName = "Сирзат Яхуп" },
               new Actor { ActorId = 33, ActorName = "Ху Цзюнь" },
               new Actor { ActorId = 34, ActorName = "Юань Цуань" },
               new Actor { ActorId = 35, ActorName = "Берик Айтжанов" },
               new Actor { ActorId = 36, ActorName = "Аружан Джазильбекова" },
               new Actor { ActorId = 37, ActorName = "Фиби Фокс" },
               new Actor { ActorId = 38, ActorName = "Левин Ллойд" },
               new Actor { ActorId = 39, ActorName = "Бенедикт Камбербэтч" },
               new Actor { ActorId = 40, ActorName = "Ник Джонас" },
               new Actor { ActorId = 41, ActorName = "Николас Холт" },
               new Actor { ActorId = 42, ActorName = "Наташа Ротуэлл" },
               new Actor { ActorId = 43, ActorName = "Элайза Сканлен" }
               );

            modelBuilder.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    MovieTitle = "Аэронавты",
                    CountStars = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/11.jpg"
                },

                new Movie
                {
                    MovieId = 2,
                    MovieTitle = "1917",
                    CountStars = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/12.jpg"
                },

                new Movie
                {
                    MovieId = 3,
                    MovieTitle = "Джуманджи: Новый уровень",
                    CountStars = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/13.jpg"
                },

                new Movie
                {
                    MovieId = 4,
                    MovieTitle = "Банкир",
                    CountStars = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/14.jpg"
                },

                new Movie
                {
                    MovieId = 5,
                    MovieTitle = "Соник в кино",
                    CountStars = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/15.jpg"
                },

                new Movie
                {
                    MovieId = 6,
                    MovieTitle = "Хищные птицы: Потрясающая история Харли Квинн",
                    CountStars = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/16.jpg"
                },

                new Movie
                {
                    MovieId = 7,
                    MovieTitle = "Маленькие женщины",
                    CountStars = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/17.jpg"
                },

                new Movie
                {
                    MovieId = 8,
                    MovieTitle = "Композитор",
                    CountStars = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/18.jpg"
                });

            modelBuilder.Entity<ActorsList>().HasData(
                new ActorsList { MovieId = 1, ActorId = 1 },
                new ActorsList { MovieId = 1, ActorId = 2 },
                new ActorsList { MovieId = 1, ActorId = 3 },
                new ActorsList { MovieId = 1, ActorId = 4 },
                new ActorsList { MovieId = 1, ActorId = 37 },
                new ActorsList { MovieId = 1, ActorId = 38 },

                new ActorsList { MovieId = 2, ActorId = 5 },
                new ActorsList { MovieId = 2, ActorId = 6 },
                new ActorsList { MovieId = 2, ActorId = 7 },
                new ActorsList { MovieId = 2, ActorId = 8 },
                new ActorsList { MovieId = 2, ActorId = 39 },

                new ActorsList { MovieId = 3, ActorId = 9 },
                new ActorsList { MovieId = 3, ActorId = 10 },
                new ActorsList { MovieId = 3, ActorId = 11 },
                new ActorsList { MovieId = 3, ActorId = 12 },
                new ActorsList { MovieId = 3, ActorId = 40 },

                new ActorsList { MovieId = 4, ActorId = 13 },
                new ActorsList { MovieId = 4, ActorId = 14 },
                new ActorsList { MovieId = 4, ActorId = 15 },
                new ActorsList { MovieId = 4, ActorId = 16 },
                new ActorsList { MovieId = 4, ActorId = 17 },
                new ActorsList { MovieId = 4, ActorId = 41 },

                new ActorsList { MovieId = 5, ActorId = 18 },
                new ActorsList { MovieId = 5, ActorId = 19 },
                new ActorsList { MovieId = 5, ActorId = 20 },
                new ActorsList { MovieId = 5, ActorId = 21 },
                new ActorsList { MovieId = 5, ActorId = 22 },
                new ActorsList { MovieId = 5, ActorId = 42 },

                new ActorsList { MovieId = 6, ActorId = 23 },
                new ActorsList { MovieId = 6, ActorId = 24 },
                new ActorsList { MovieId = 6, ActorId = 25 },
                new ActorsList { MovieId = 6, ActorId = 26 },

                new ActorsList { MovieId = 7, ActorId = 27 },
                new ActorsList { MovieId = 7, ActorId = 28 },
                new ActorsList { MovieId = 7, ActorId = 29 },
                new ActorsList { MovieId = 7, ActorId = 30 },
                new ActorsList { MovieId = 7, ActorId = 31 },
                new ActorsList { MovieId = 7, ActorId = 43 },

                new ActorsList { MovieId = 8, ActorId = 32 },
                new ActorsList { MovieId = 8, ActorId = 33 },
                new ActorsList { MovieId = 8, ActorId = 34 },
                new ActorsList { MovieId = 8, ActorId = 35 },
                new ActorsList { MovieId = 8, ActorId = 36 }
                );
        }
    }
}
