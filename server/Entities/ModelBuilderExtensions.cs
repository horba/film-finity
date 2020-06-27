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
               new Actor { Id = 1, FullName = "Том Харпер" },
               new Actor { Id = 2, FullName = "Филисити Джонс" },
               new Actor { Id = 3, FullName = "Эдди Редмейн" },
               new Actor { Id = 4, FullName = "Химет Патель" },
               new Actor { Id = 5, FullName = "Режиссер" },
               new Actor { Id = 6, FullName = "Джордж Маккей" },
               new Actor { Id = 7, FullName = "Дин-Чарльз Чакман" },
               new Actor { Id = 8, FullName = "Ричард Мэдден" },
               new Actor { Id = 9, FullName = "Джордж Нолфи" },
               new Actor { Id = 10, FullName = "Энтони Маки" },
               new Actor { Id = 11, FullName = "Сэмюел Лерой Джексон" },
               new Actor { Id = 12, FullName = "Ниа Лонг" },
               new Actor { Id = 13, FullName = "Джейк Кэздан" },
               new Actor { Id = 14, FullName = "Дуэйн Джонсон" },
               new Actor { Id = 15, FullName = "Карен Гиллан" },
               new Actor { Id = 16, FullName = "Джейк Блэк" },
               new Actor { Id = 17, FullName = "Кевин Харт" },
               new Actor { Id = 18, FullName = "Джефф Фаулер" },
               new Actor { Id = 19, FullName = "Джим Керри" },
               new Actor { Id = 20, FullName = "Джеймс Марсден" },
               new Actor { Id = 21, FullName = "Тика Самптер" },
               new Actor { Id = 22, FullName = "Бен Шварц" },
               new Actor { Id = 23, FullName = "Мэти Янь" },
               new Actor { Id = 24, FullName = "Марго Робби" },
               new Actor { Id = 25, FullName = "Джерни Смоллет-Белл" },
               new Actor { Id = 26, FullName = "Мэри Элизабет Уинстэд" },
               new Actor { Id = 27, FullName = "Грета Гервич" },
               new Actor { Id = 28, FullName = "Сирта Ронан" },
               new Actor { Id = 29, FullName = "Тимоти Шаламе" },
               new Actor { Id = 30, FullName = "Флоренс Пью" },
               new Actor { Id = 31, FullName = "Эмма Уотсон" },
               new Actor { Id = 32, FullName = "Сирзат Яхуп" },
               new Actor { Id = 33, FullName = "Ху Цзюнь" },
               new Actor { Id = 34, FullName = "Юань Цуань" },
               new Actor { Id = 35, FullName = "Берик Айтжанов" },
               new Actor { Id = 36, FullName = "Аружан Джазильбекова" },
               new Actor { Id = 37, FullName = "Фиби Фокс" },
               new Actor { Id = 38, FullName = "Левин Ллойд" },
               new Actor { Id = 39, FullName = "Бенедикт Камбербэтч" },
               new Actor { Id = 40, FullName = "Ник Джонас" },
               new Actor { Id = 41, FullName = "Николас Холт" },
               new Actor { Id = 42, FullName = "Наташа Ротуэлл" },
               new Actor { Id = 43, FullName = "Элайза Сканлен" }
               );

            modelBuilder.Entity<Movie>().HasData(

                new Movie
                {
                    Id = 1,
                    Title = "Аэронавты",
                    Rate = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/Aeronauts.jpg"
                },

                new Movie
                {
                    Id = 2,
                    Title = "1917",
                    Rate = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/1917.jpg"
                },

                new Movie
                {
                    Id = 3,
                    Title = "Джуманджи: Новый уровень",
                    Rate = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/JumanjiNL.jpg"
                },

                new Movie
                {
                    Id = 4,
                    Title = "Банкир",
                    Rate = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/Banker.jpg"
                },

                new Movie
                {
                    Id = 5,
                    Title = "Соник в кино",
                    Rate = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/SonikH.jpg"
                },

                new Movie
                {
                    Id = 6,
                    Title = "Хищные птицы: Потрясающая история Харли Квинн",
                    Rate = 5,
                    ReleaseYear = 2020,
                    ImageSource = "StaticFiles/images/PreyBirdsHQ.jpg"
                },

                new Movie
                {
                    Id = 7,
                    Title = "Маленькие женщины",
                    Rate = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/LittleWomen.jpg"
                },

                new Movie
                {
                    Id = 8,
                    Title = "Композитор",
                    Rate = 5,
                    ReleaseYear = 2019,
                    ImageSource = "StaticFiles/images/Composer.jpg"
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
