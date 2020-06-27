using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
                new JobTitle { JobTitleId = 6, JobName = "композитор" },
                new JobTitle { JobTitleId = 7, JobName = "актриса" });

<<<<<<< HEAD
            modelBuilder.Entity<Celebrity>().HasData(

                new Celebrity
                {
                    CelebrityId = -1,
                    FirstName = "Хью",
                    LastName = "Джекман",
                    CountViews = 134000,
                    ImageSource = "StaticFiles/images/1.jpg",

                    Birthday = "12 октября 1968 г.",
                    FamilyStatus = "в гражданском браке с Деборра-Ли Фёрнесс",
                    Height = "188 см",
                    PlaceOfBirthday = "Сидней, Австралия",
                    StarSing = "Весы",
                    Achievement = "Известный по фильмам \"Люди Икс: Дни минувшего будущего\", \"Престиж\" и др."
=======
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "фантастика" },
                new Genre { Id = 2, Name = "драма" },
                new Genre { Id = 3, Name = "триллер" },
                new Genre { Id = 4, Name = "боевик" },
                new Genre { Id = 5, Name = "приключения" },
                new Genre { Id = 6, Name = "детектив" },
                new Genre { Id = 7, Name = "комедия" },
                new Genre { Id = 8, Name = "ужасы" });

            modelBuilder.Entity<Serial>().HasData(

                new Serial
                {
                    Id = 1,
                    Name = "Видоизменённый углерод (1-2 сезон)",
                    Rating = 3,
                    Year = 2018,
                    PosterImageSource = "StaticFiles/images/11.jpg"
                },

                new Serial
                {
                    Id = 2,
                    Name = "Викинги (1-6 сезон)",
                    Rating = 4,
                    Year = 2013,
                    PosterImageSource = "StaticFiles/images/12.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -2,
                    FirstName = "Райан",
                    LastName = "Рейнольдс",
                    CountViews = 127000,
                    ImageSource = "StaticFiles/images/2.jpg",

                    Birthday = "23 октября 1976 г.",
                    FamilyStatus = "в браке с Блейк Лайвли",
                    Height = "188 см",
                    PlaceOfBirthday = "Ванкувер, Канада",
                    StarSing = "Весы",
                    Achievement = "Известный по фильмам \"Дэдпул\", \"Погребённый заживо\" и др."
                },
                new Celebrity
                {
                    CelebrityId = -3,
                    FirstName = "Роберт",
                    LastName = "Дауни (младший)",
                    CountViews = 126000,
                    ImageSource = "StaticFiles/images/3.jpg",

                    Birthday = "4 апреля 1965 г.",
                    FamilyStatus = "в браке с Сьюзан Дауни",
                    Height = "174 см",
                    PlaceOfBirthday = "Нью-Йорк, США",
                    StarSing = "Овен",
                    Achievement = "Известный по многосерийным фильмом \"Мстители\", \"Шерлок Холмс\" и др."
=======
                    Id = 3,
                    Name = "Ведьмак (1 сезон)",
                    Rating = 5,
                    Year = 2019,
                    PosterImageSource = "StaticFiles/images/13.jpg"
                },

                new Serial
                {
                    Id = 4,
                    Name = "Чужак (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/14.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -4,
                    FirstName = "Уилл",
                    LastName = "Смит",
                    CountViews = 121000,
                    ImageSource = "StaticFiles/images/4.jpg",

                    Birthday = "25 сентября 1968 г.",
                    FamilyStatus = "в  браке с Джада Пинкетт Смит",
                    Height = "188 см",
                    PlaceOfBirthday = "Филадельфия, США",
                    StarSing = "Весы",
                    Achievement = "Известный по фильмам \"В погоне за счастьем\", \"Люди в чёрном\" и др."
                },
                new Celebrity
                {
                    CelebrityId = -5,
                    FirstName = "Брэд",
                    LastName = "Питт",
                    CountViews = 120500,
                    ImageSource = "StaticFiles/images/5.jpg",

                    Birthday = "18 декабря 1963 г.",
                    FamilyStatus = "в разводе с Анджелиной Джоли",
                    Height = "180 см",
                    PlaceOfBirthday = "Шони, Оклахома, США",
                    StarSing = "Стрелец",
                    Achievement = "Известный по фильмам \"Человек, который изменил всё\", \"Загадочная история Бенджамина Баттона\" и др."
=======
                    Id = 5,
                    Name = "Маленькая Америка (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/15.jpg"
                },

                new Serial
                {
                    Id = 6,
                    Name = "Пятая авеню (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/16.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -6,
                    FirstName = "Леонардо",
                    LastName = "Ди Каприо",
                    CountViews = 120000,
                    ImageSource = "StaticFiles/images/6.jpg",

                    Birthday = "11 ноября 1974 г.",
                    FamilyStatus = "в отношениях с Камилой Морроне",
                    Height = "183 см",
                    PlaceOfBirthday = "Лос-Анджелес, США",
                    StarSing = "Скорпион",
                    Achievement = "Известный по фильмам \"Начало\", \"Волк с Уолл-стрит\" и др."
=======
                    Id = 7,
                    Name = "Звёздный путь: Пикар (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/17.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -7,
                    FirstName = "Натали",
                    LastName = "Портман",
                    CountViews = 91000,
                    ImageSource = "StaticFiles/images/7.jpg",

                    Birthday = "9 июня 1981 г.",
                    FamilyStatus = "в браке с Бенджамин Мильпье",
                    Height = "160 см",
                    PlaceOfBirthday = "Иерусалим, Израиль",
                    StarSing = "Близнецы",
                    Achievement = "Известная по фильмам \"Леон\", \"V - значит вендетта\" и др."
=======
                    Id = 8,
                    Name = "Замок и ключ (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/18.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -8,
                    FirstName = "Роджер",
                    LastName = "Дикинс",
                    CountViews = 20000,
                    ImageSource = "StaticFiles/images/8.jpg",

                    Birthday = "24 мая 1949 г.",
                    FamilyStatus = "в браке с Изабелла Джеймс Пьюрфой Эллис",
                    Height = "178 см",
                    PlaceOfBirthday = "Торки, Великобритания",
                    StarSing = "Близнецы",
                    Achievement = "Известный по фильмам \"Побег из Шоушенка\", \"Игры разума\" и др."
=======
                    Id = 9,
                    Name = "Hi-Fi / Фанатик (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/19.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -9,
                    FirstName = "Ханс",
                    LastName = "Циммер",
                    CountViews = 50000,
                    ImageSource = "StaticFiles/images/9.png",

                    Birthday = "12 сентября 1959 г.",
                    FamilyStatus = "в браке с Сюзанна Циммер",
                    Height = "178 см",
                    PlaceOfBirthday = "Франкфурт-на-Майне, Германия",
                    StarSing = "Дева",
                    Achievement = "Известный по композициям в фильмах и мультфильмах \"Гладиатор\", \"Король Лев\" и др."
=======
                    Id = 10,
                    Name = "Разрабы (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/20.jpg"
>>>>>>> dev
                },

                new Serial
                {
<<<<<<< HEAD
                    CelebrityId = -10,
                    FirstName = "Квентин",
                    LastName = "Тарантино",
                    CountViews = 95000,
                    ImageSource = "StaticFiles/images/10.jpg",

                    Birthday = "27 марта 1963 г.",
                    FamilyStatus = "в браке с Даниэла Пик",
                    Height = "185 см",
                    PlaceOfBirthday = "Ноксвилл, Теннесси, США",
                    StarSing = "Овен",
                    Achievement = "Известный по фильмам \"Криминальное чтиво\", \"Омерзительная восьмерка\" и др."
                },
                new Celebrity
                {
                    CelebrityId = -11,
                    FirstName = "Зои",
                    LastName = "Казан",
                    CountViews = 9050,
                    ImageSource = "StaticFiles/images/11.jpg",

                    Birthday = "9 сентября 1983 г.",
                    FamilyStatus = "в браке с Пол Дано",
                    Height = "163 см",
                    PlaceOfBirthday = "Лос-Анджелес, США",
                    StarSing = "Дева",
                    Achievement = "Известная по фильмам \"Простые сложности\", \"Дорога перемен\" и др."
=======
                    Id = 11,
                    Name = "Охотники (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/21.jpg"
>>>>>>> dev
                });

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

            modelBuilder.Entity<SerialCelebrity>().HasData(
                new SerialCelebrity { SerialId = 4, CelebrityId = -1 },
                new SerialCelebrity { SerialId = 4, CelebrityId = -2 },
                new SerialCelebrity { SerialId = 4, CelebrityId = -3 },

                new SerialCelebrity { SerialId = 5, CelebrityId = -4 },
                new SerialCelebrity { SerialId = 5, CelebrityId = -5 },
                new SerialCelebrity { SerialId = 5, CelebrityId = -6 },

                new SerialCelebrity { SerialId = 6, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 6, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 6, CelebrityId = -9 },

                new SerialCelebrity { SerialId = 7, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 7, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 7, CelebrityId = -9 },

                new SerialCelebrity { SerialId = 8, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 8, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 8, CelebrityId = -9 },

                new SerialCelebrity { SerialId = 9, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 9, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 9, CelebrityId = -9 },

                new SerialCelebrity { SerialId = 10, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 10, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 10, CelebrityId = -9 },

                new SerialCelebrity { SerialId = 11, CelebrityId = -7 },
                new SerialCelebrity { SerialId = 11, CelebrityId = -8 },
                new SerialCelebrity { SerialId = 11, CelebrityId = -9 }
                );

            modelBuilder.Entity<SerialGenreTitles>().HasData(
                new SerialGenreTitles { SerialId = 1, GenreId = 1 },
                new SerialGenreTitles { SerialId = 1, GenreId = 2 },
                new SerialGenreTitles { SerialId = 1, GenreId = 3 },

                new SerialGenreTitles { SerialId = 2, GenreId = 2 },
                new SerialGenreTitles { SerialId = 2, GenreId = 4 },
                new SerialGenreTitles { SerialId = 2, GenreId = 5 },

                new SerialGenreTitles { SerialId = 3, GenreId = 2 },
                new SerialGenreTitles { SerialId = 3, GenreId = 4 },
                new SerialGenreTitles { SerialId = 3, GenreId = 5 },

                new SerialGenreTitles { SerialId = 4, GenreId = 2 },
                new SerialGenreTitles { SerialId = 4, GenreId = 4 },
                new SerialGenreTitles { SerialId = 4, GenreId = 5 },

                new SerialGenreTitles { SerialId = 5, GenreId = 2 },
                new SerialGenreTitles { SerialId = 5, GenreId = 4 },
                new SerialGenreTitles { SerialId = 5, GenreId = 5 },

                new SerialGenreTitles { SerialId = 6, GenreId = 2 },
                new SerialGenreTitles { SerialId = 6, GenreId = 4 },
                new SerialGenreTitles { SerialId = 6, GenreId = 5 },

                new SerialGenreTitles { SerialId = 7, GenreId = 2 },
                new SerialGenreTitles { SerialId = 7, GenreId = 4 },
                new SerialGenreTitles { SerialId = 7, GenreId = 5 },

                new SerialGenreTitles { SerialId = 8, GenreId = 2 },
                new SerialGenreTitles { SerialId = 8, GenreId = 4 },
                new SerialGenreTitles { SerialId = 8, GenreId = 5 },

                new SerialGenreTitles { SerialId = 9, GenreId = 2 },
                new SerialGenreTitles { SerialId = 9, GenreId = 4 },
                new SerialGenreTitles { SerialId = 9, GenreId = 5 },

                new SerialGenreTitles { SerialId = 10, GenreId = 2 },
                new SerialGenreTitles { SerialId = 10, GenreId = 4 },
                new SerialGenreTitles { SerialId = 10, GenreId = 5 },

                new SerialGenreTitles { SerialId = 11, GenreId = 2 },
                new SerialGenreTitles { SerialId = 11, GenreId = 4 },
                new SerialGenreTitles { SerialId = 11, GenreId = 5 }
                );
            modelBuilder.Entity<CelebrityJobTitles>().HasData(
                new CelebrityJobTitles { CelebrityId = -1, JobTitleId = 1 },
                new CelebrityJobTitles { CelebrityId = -1, JobTitleId = 4 },

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
                new CelebrityJobTitles { CelebrityId = -10, JobTitleId = 4 },

                new CelebrityJobTitles { CelebrityId = -11, JobTitleId = 4 },
                new CelebrityJobTitles { CelebrityId = -11, JobTitleId = 3 },
                new CelebrityJobTitles { CelebrityId = -11, JobTitleId = 7 }
                );

            modelBuilder.Entity<CelebrityNetworkingSites>().HasData(
                new CelebrityNetworkingSites
                {
                    CelebrityId = -1,
                    Facebook = "https://www.facebook.com/HughJackman/",
                    Twitter = "https://twitter.com/realhughjackman",
                    Instagram = "https://www.instagram.com/thehughjackman/?hl=ru"
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -2,
                    Facebook = "https://www.facebook.com/VancityReynolds/",
                    Twitter = "https://twitter.com/vancityreynolds",
                    Instagram = "https://www.instagram.com/vancityreynolds/?hl=ru"
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -3,
                    Facebook = "https://www.facebook.com/robertdowneyjr/",
                    Twitter = "https://twitter.com/robertdowneyjr",
                    Instagram = "https://www.instagram.com/robertdowneyjr/?hl=ru"
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -4,
                    Facebook = "https://www.facebook.com/Will-Smith-92304305160/",
                    Instagram = "https://www.instagram.com/willsmith/?hl=ru",
                    Twitter = ""
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -5,
                    Facebook = "",
                    Twitter = "",
                    Instagram = ""
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -6,
                    Facebook = "https://www.facebook.com/LeonardoDiCaprio/",
                    Twitter = "https://twitter.com/leodicaprio",
                    Instagram = "https://www.instagram.com/leonardodicaprio/?hl=ru"
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -7,
                    Instagram = "https://www.instagram.com/natalieportman/?hl=ru",
                    Facebook = "",
                    Twitter = ""
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -8,
                    Instagram = "",
                    Facebook = "",
                    Twitter = ""
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -9,
                    Facebook = "https://www.facebook.com/hanszimmer/",
                    Twitter = "https://twitter.com/hanszimmer",
                    Instagram = "https://www.instagram.com/hanszimmer/?hl=ru"
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -10,
                    Facebook = "",
                    Twitter = "",
                    Instagram = ""
                },
                new CelebrityNetworkingSites
                {
                    CelebrityId = -11,
                    Facebook = "",
                    Twitter = "https://twitter.com/zoeinthecities",
                    Instagram = "https://www.instagram.com/zoe.kazan/?hl=ru"
                }
                );

            modelBuilder.Entity<CelebrityBiography>().HasData(

               new CelebrityBiography
               {
                   CelebrityId = -1,
                   ShortDescription =
                   "<h2>Биография</h2>" +
                   "<p>" +
                    "Звезда Голливуда имеет сегодня многомиллионную армию поклонников, самые важные премии в области кинематографа " +
                    "и театра, а фильмы с Хью Джекманом пользуются огромной популярностью. " +
                    "Всемирную славу принесла актеру роль мутанта Росомахи из киновселенной «Люди Икс»." +
                   "</p>",
                   ChildhoodAndYouth =
                   "<h2>Детство и юность</h2>" +
                   "<p>" +
                    "Хью Майкл Джекман появился на свет в Сиднее, под зодиакальным созвездием Весов, в 1968 году. " +
                    "В Австралию его родители-англичане приехали в рамках программы по освоению Зеленого континента. Предки по отцовской линии – греки по национальности." + 
                   "</p>" +
                   "<p>" +
                    "Глава семейства Кристофер Джекман работал бухгалтером, мать Грейс Уотсон занималась домашним хозяйством " +
                    "и детьми. У Хью есть сёстры Соня и Зои и братья Иен и Ральф." +
                   "</p>" +
                   "<p>" +
                    "После рождения младшего сына у Грейс обнаружилась послеродовая депрессия, и мальчик полтора года жил у крёстных " +
                    "родителей. Но и после его возвращения домой проблемы не исчезли. Грейс не смогла прижиться в чужой стране." +
                   "</p>" +
                   "<p>" +
                    "Однажды, вернувшись со школьных занятий, Джекман попал в пустой дом - мать уехала в Лондон. Через несколько лет женщина " +
                    "забрала к себе дочерей, а сыновья остались на попечении отца. С матерью актер наладил отношения только в 2011 году." +             
                   "</p>" +
                   "<p>" +
                    "В школе Хью Джекман увлёкся баскетболом и даже стал капитаном команды. После парень выбрал технологический " +
                    "университет в Сиднее, где обучался на факультете журналистики. В этот период он хватался за любую работу, " +
                    "так как поддержать сына материально родители не могли. Хью трудился на бензоколонке и в ресторане, развлекал " +
                    "детей в торговом центре в качестве клоуна." +
                   "</p>" +
                   "<p>" +
                    "Под финал учебы в университете Джекману предложили выбрать дополнительные курсы. Он остановился на " +
                    "драматическом искусстве, да так увлёкся, что решил продолжить образование в театральном вузе. Получив диплом " +
                    "журналиста, Джекман поступил в австралийскую академию изобразительных искусств." + 
                   "</p>",
                   PersonalLife =
                   "<h2>Личная жизнь</h2>" +
                   "<p>" +
                    "У австралийского актёра крепкая семья. Личная жизнь Хью Джекмана наладилась в 1996 году, когда он встретил Деборру-Ли Фернесс " +
                    "на съемках картины «Корелли». Несмотря на то, что жена старше мужа на 13 лет, пару считают одной из самых крепких на Голливудских холмах." +
                   "</p>" +
                   "<p>" +
                    "Кстати, из-за разницы в возрасте Деборра поначалу не отвечала на знаки внимания Хью и сдалась, только когда мама посоветовала " +
                    "не переживать по столь незначительному поводу. А отец Джекмана поинтересовался, не связан ли выбор сына с ощущением нехватки " +
                    "материнской заботы." +
                   "</p>" +
                   "<p>" +
                    "Фернесс – лауреат Премии кинокритиков Австралии, занимается делами продюсерской компании Seed Productions, " +
                    "основанной супругами совместно с Джоном Палермо, продюсером картины «Люди Икс: Начало. Росомаха». " +
                    "Дебютным проектом студии стал сериал «Вива Лафлин», который вышел на экраны в 2007-м. По части " +
                    "детей у пары был план – обзавестись двумя собственными, а потом еще усыновить. Реализовался только второй пункт. " +
                    "Сын Оскар Максимилиан – не белой расы, дочь Ава Элиот наполовину немка, наполовину мексиканка." +
                    "Фернесс и Джекман присутствовали при рождении мальчика и сознательно взяли ребенка с цветом кожи, который " +
                    "многих приемных родителей отпугивает. Кроме этого, жена актера помогает семьям и одиноким " +
                    "женщинам из африканских стран получить банковские займы и открыть cвой бизнес." +
                   "</p>" +
                   "<p>" +
                    "В 2017-м появились слухи, что звездная пара на грани развода. Виной тому будто бы постоянные разъезды Хью, тогда как " +
                    "Деборра остается в Австралии. Представителю актера пришлось выступить с официальным опровержением." +
                   "</p>" +
                   "<p>" +
                    "Спустя три года папарацци нашли еще повод для ревности Фернесс, приписав eё благоверному интрижку с Брук Шилдс. " +
                    "Oсобо внимательные разглядели, что мужчина перестал носить обручальное кольцо." +
                   "</p>" +
                   "<p>" +
                    "Однако Джекман до сих пор испытывает ко второй половине чувства, как в первый день и считает cвой брак образцовым. " +
                    "Супруги расстаются максимум на 36 часов. Расстояние для них не помеха: если глава семьи где-то снимается, остальные " +
                    "обязательно к нему приезжают." +
                   "</p>" +
                   "<p>" +
                    "В свободное время Хью Джекман играет в гольф, занимается виндсерфингом и медитацией. " +
                    "Актер не курит и даже к сценам употребления табака в фильмах относится отрицательно." +
                   "</p>" +
                   "<p>" +
                    "В 2013 году СМИ распространили информацию, что кинозвезда чуть ли не умирает от рака кожи. Вскоре выяснилось, что Хью " +
                    "болен легкой формой базально-клеточной карценомы, которая, по счастью, даёт метастазы только в 10 % случаев. " +
                    "Так что состояние здоровья знаменитости опасений не вызывает." +
                   "</p>" +
                   "<p>" +
                    "Актер, перенесший не одну операцию и не отрицающий, что возможны новообразования, на странице в «Инстаграме» публикует " +
                    "фото в повязках и призывает пользоваться солнцезащитными препаратами. В интервью Джекман признался, что в молодости, " +
                    "хотя и жил на континенте, где круглый год лето, не подозревал, чем может обернуться избыточная инсоляция." +
                   "</p>" +
                   "<p>" +
                    "Как благотворитель Хью поддерживает организации по борьбе с глобальным потеплением и бедностью, Австралийский институт " +
                    "костного мозга и творческое сообщество The Art of Elysium. Доход от его сети кофеен направляется в фонд Laughing Man, " +
                    "который финансирует образовательные программы." +
                   "</p>",
                   CareerInCinema =
                   "<h2>Карьера в кино</h2>" +
                   "<p>" +
                    "Кинематографическая биография Хью Джекмана началась в студенческие годы. В 1994-м молодому актёру предложили роль в " +
                    "остросюжетном сериале «Корелли» о мужской тюрьме. Женщину-психолога играла будущая супруга Деборра-Ли Фернесс. " +
                    "Хью изображал её самого проблемного пациента - заключённого Джонса." +
                   "</p>" +
                    "В следующие 4 года Хью снялся в нескольких сериалах. А в 1998-м артисту предложили главную роль в картине «Герой её романа». " +
                    "Переломным для актёра стал 1999 год, когда его в последний момент утвердили в роли Росомахи в голливудской картине «Люди Икс»." +
                   "<p>" +
                    "В 2001 году Джекману предложили центральную роль в комедийной ленте «Кейт и Лео». За образ дворянина Леопольда, обаятельного и " +
                    "романтичного, актер номинирован на «Золотой глобус». В этом же году Хью вместе с Джоном Траволтой и Холли Берри снялся в " +
                    "боевике «Пароль Рыба-меч». С этого момента Джекман сам выбирает, в каком фильме будет сниматься, причём этот выбор не всегда " +
                    "определяется размером гонорара." +
                   "</p>" +
                    "В 2004 году артист снялся в главной роли охотника за вампирами в фантастической картине Стивена Соммерса «Ван Хельсинг». " +
                    "Несмотря на то, что в фильме выявлен ряд фактических ошибок, он принёс огромные коммерческие сборы. " +
                    "Создать неповторимую атмосферу Джекману помогали Кейт Бекинсейл, Ричард Роксбург, Дэвид Уэнэм и другие." +
                   "<p>" +
                    "Проектов с фантастическим или историческим сюжетом в карьере Хью немало. Актер привлекался в боевик «Живая сталь» " +
                    "о борьбе людей и андроидов, триллер «Робот по имени Чаппи», в котором механизмы с искусственным интеллектом " +
                    "ни в чем не уступают людям, в не самый удачный фильм для семейного просмотра «Пэн: Путешествие в Нетландию»." +
                   "</p>" +
                   "<p>" +
                    "В 2006-м Хью появился в комедийной ленте «Сенсация» легендарного Вуди Аллена. Он сыграл перспективного молодого " +
                    "политика, аристократа, которого ошибочно приняли за маньяка-убийцу. Правду раскрывает амбициозная героиня Скарлетт " +
                    "Йоханссон. В этом же году Джекман снялся в главной роли в картине «Престиж» Кристофера Нолана, где блестяще " +
                    "изобразил фокусника-иллюзиониста Энджера." +
                   "</p>" +
                   "<p>" +
                    "Большинство кинокритиков считают лучшей ролью Хью Джекмана работу в картине «Пленницы». Этот детективный триллер " +
                    "вышел в 2013 году и номинирован на «Оскар» и трижды – на «Спутник», удостоен награды от Национального совета " +
                    "американских кинокритиков. Кроме того, фильм вошел в список 10 лучших фильмов 2013-го. В числе партнеров Джекмана " +
                    "по проекту – исполнители ролей антагониста Джейк Джилленхол и жертвы Пол Дано." +
                   "</p>" +
                   "<p>" +
                    "Джекман нередко становится героем рекламных роликов. Спортивного мужчину (рост – 188 см, вес – 80 кг) с обаятельной " +
                    "улыбкой выбрала на роль амбассадора компания Montblanc, производитель элитных аксессуаров. Языком танца актер " +
                    "рассказывал о преимуществах продукции бренда «Липтон», сидел за рулем автомобилей премиум-класса «Ауди» и «Тойота»." +
                    "и кинопремий, а Хью получил «Золотой глобус». В декабре того же года на «Аллее славы» в Голливуде появилась именная " +
                    "звезда австралийского актёра. Журнал Forbs включил его в рейтинг самых влиятельных мужчин. В тройку лидеров тогда вошли " +
                    "Роберт Дауни-младший и Леонардо ДиКаприо." +
                   "</p>" +
                   "<p>" +
                    "На почве рекламы состоялось своеобразное «примирение» Хью с Райаном Рейнольдсом. Коллеги постоянно подшучивали друг над " +
                    "другом и в жизни, и в кинопроектах. В итоге Рейнольдс снял рекламу для компании Laughing Man Coffee, лицом и владельцем " +
                    "которой является Джекман. В ответ получил ролик, рассказывающий о марке джина Aviation, который он представляет." +
                   "</p>" +
                   "<p>" +
                    "В 2019 году Хью отправился в мировое турне с программой The Man. The Music. The Show, в которой поет песни из альбома " +
                    "The Greatest Showman: Original Motion Picture Soundtrack и другие композиции из бродвейских постановок." +
                   "</p>" +
                   "<p>" +
                    "Следом в фильмографии Хью Джекмана появился еще один байопик, посвященный кандидату в президенты США сенатору Гэри Харту. " +
                    "В картине под названием «Как не стать президентом» главный герой изменял своей жене, что в конечном итоге привело к " +
                    "провалу предвыборной кампании и вывело в лидеры Джорджа Буша-старшего. Экранную супругу Джекмана сыграла Вера Фармига." +
                   "</p>",
                   AdditionalInfo =
                   "<h2>Театр</h2>" +
                   "<p>" +
                    "Творческая биография Хью Джекмана была бы неполной без упоминания о его театральных работах. Здесь артист добился " +
                    "не меньших успехов, чем в кинематографе. По окончании театрального вуза в Австралии Хью, умевший отлично петь и " +
                    "танцевать, отметился в мюзиклах «Красавица и чудовище» и «Бульвар Сансет». Оба получили несколько премий и тёплые " +
                    "отзывы критиков." +
                   "</p>" +
                   "<p>" +
                    "В конце 1990-х актер получил приглашение от Национального королевского театра в Лондоне сыграть в мюзикле «Оклахома!». " +
                    "Постановка имела громадный успех, а Джекман дважды номинировался на высшую театральную премию Великобритании имени " +
                    "Лоуренса Оливье. С тех пор Хью часто играет на Бродвее. Яркая игра на сцене и в кино дала ему право попасть в число " +
                    "лучших актеров Австралии в 1999-м." +
                   "</p>" +
                   "<p>" +
                    "В 2003 году Джекману предложено сыграть в мюзикле «Призрак Оперы», но он отказался и предпочёл постановку «Мальчик из " +
                    "страны Оз» своего земляка Питера Аллена. Спектакль шел год и получил рекордные сборы. Сам актер стал обладателем так " +
                    "называемой «тройной короны Бродвея» (главных театральных премий). На сегодня Хью – единственный артист, получивший в " +
                    "одном сезоне все основные награды." +
                   "</p>",
               },
               new CelebrityBiography
               {
                   CelebrityId = -2,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -3,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -4,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -5,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -6,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -7,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -8,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -9,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -10,
                   ShortDescription = "",
                   ChildhoodAndYouth = "",
                   PersonalLife = "",
                   CareerInCinema = "",
                   AdditionalInfo = ""
               },
               new CelebrityBiography
               {
                   CelebrityId = -11,
                   ShortDescription =
                   "<h2>Биография</h2>" +
                   "<p>" +
                    "Даже для творческой личности актриса Зои Казан — уникум. Её отличают не только необычная внешность, " +
                    "но и пластическая выразительность, умение тонко чувствовать персонажа и воплощать его в жизнь. Вероятно, секрет кроется " +
                    "в том, что Зои ещё и сценарист. Её перу принадлежат фильмы «Руби Спаркс» и «Дикая жизнь»." +
                   "</p>",
                   ChildhoodAndYouth =
                   "<h2>Детсво и юность</h2>" +
                   "<p>Зои Свайкорд Казан родилась 9 сентября 1983 года в Лос-Анджелесе, штат Калифорния.</p>" +
                   "<p>" +
                    "Любовь к творчеству актрисе и её сестре Майе передалась по наследству: родители — сценаристы Николас Казан и " +
                    "Робин Свайкорд, а дедушка с бабушкой — режиссёр Элиа Казан и драматург Молли Казан (в девичестве Тэтчер). " +
                    "Они прекрасно знали,как воспитать разносторонне развитую личность, поскольку сами были такими." +
                    "Сама Зои Казан, кстати, не считает, что причина её творческого склада ума кроется в наследственности. В интервью «Кинопоиску» актриса сказала:" +
                   "</p>" +
                   "<p>" +
                    "<strong>«Думаю, наследственность — это лишь малая часть, в основном имеет значение твой интерес, " +
                    "и насколько ты хочешь чего - то добиться.Мой стержень — это страсть, именно она заставляет меня просыпаться " +
                    "каждое утро и работать не покладая рук».</strong>" +
                   "</p>" +
                   "<p>" +
                    "Интерес к творчеству в сестрах Казан проснулся рано.В детстве они часто ходили в музеи.Зои могла часами напролёт " +
                    "любоваться картинами Эдварда Берн - Джонса, а Майя перерисовывала пейзажи.Девочки не зацикливались на определённом виде " +
                    "искусства — интересовались живописью, «проглатывали» книги, приобщались к разным музыкальным направлениям, от оперы до джаза." +
                   "</p>" +
                   "<p>" +
                    "Общее образование Зои Казан получала в частных школах Wildwood, Windward и Marlborough в Лос - Анджелесе. " +
                    "Затем актриса поступила в Йельский университет — альма - матер своего дедушки Элиа Казана. Она входила в " +
                    "Общество рукописей — коллектив драматургов, где впервые проявился литературный талант американки." +
                   "</p>" +
                   "<p>Йельский университет Зои Казан окончила в 2005 году со степенью бакалавра драматических искусств.</p>",
                   PersonalLife =
                   "<h2>Личная жизнь</h2>" +
                   "<p>" +
                    "В 2007 году на съёмках фильма «Обход Мика» (2010) Зои Казан познакомилась с актёром Полом Дано. " +
                    "Романтический интерес молодых людей развился достаточно быстро. Пара вместе и сейчас</p>" +
                   "<p>" +
                    "По словам Зои, с Полом она проводит по 14 часов в день, и это только по работе. На съемочной площадке и за её пределами " +
                    "актёры делятся друг с другом творческими достижениями, радуются за победы и огорчаются неудачам. " +
                    "Времени на личную жизнь — вот чего влюблённым по-настоящему не хватает. В начале 2018 года Зои Казан " +
                    "появилась на публике с заметно округлившимся животом. Таблоиды наперебой начали утверждать, " +
                    "что актриса беременная. И действительно — в августе того же года на свет появилась дочь Альма Бэй Дано." +
                   "</p>",
                   CareerInCinema = 
                   "<h2>Карьера в кино</h2>" +
                   "<p>" +
                    "Свой путь в кино Зои Казан начала с драмы «Шпагоглататели и худые» (2003). Ирония в том, что актриса на 100 % " +
                    "соответствует названию фильма — при росте 163 см весит не больше 50 кг. " +
                   "</p>" +
                    "В 2006 году американка, следуя за полученной в Йельском университете профессией, дебютировала на Бродвее. " +
                    "Постановка, с которой Зои Казан впервые появилась " +
                    "на театральных подмостках, — «Расцвет мисс Джин Броди» с Синтией Никсон в главной роли. Осенью 2007-го актриса получила " +
                    "возможность сыграть более цельных персонажей в пьесах «100 святых, которых вы должны знать» и «Вещи, которые мы хотим»." +
                   "<p>" +
                    "Шло время, и популярность Зои Казан росла. Несмотря на участие в серьезных кинопроектах «В долине Эла» (2007), «Я и " +
                    "Орсон Уэллс» (2008), американка рославилась благодаря театру. В 2009 году она написала пьесу «Абсалом» об отношениях " +
                    "отцов и детей. Произведение позже вошло в программу Йельского университета." +
                   "</p>" +
                    "Это событие привлекло более пристальное внимание Бродвея к Зои Казан. Её пригласили сыграть дочь героини Мерил Стрип " +
                    "в комедии «Это сложно», затем актриса разделила сцену Behanding in Spokane с Кристофером Уокеном и Сэмом Рокуэллом. " +
                    "Тут-то и посыпались предложения от кинорежиссёров." +
                   "<p>" +
                    "«Я ненавижу День святого Валентина» (2009) — это проект, открывший череду главных ролей в фильмографии " +
                    "Зои Казан. Спустя несколько месяцев состоялась премьера «Взрывной девушки», а год спустя на большие экраны вышли " +
                    "«Счастливы вместе» (2010) и «Обход Мика» (2010). " +
                   "</p>" +
                   "<p>" +
                    "С молодости Зои Казан умела совмещать несколько дел одновременно. Она выступала на сцене, снималась в кино, " +
                    "а в перерывах сочиняла стихи и романы, хотя никогда не думала, что писательство станет её профессией." +
                   "</p>" +
                   "<p>" +
                    "Впервые в осознанном возрасте Зои Казан взяла в руки блокнот и ручку, когда стала актрисой и начала ходить по пробам." +
                    "Она могла по полгода сидеть без работы и это время посвящала сочинительству. Американка выплёскивала мысли на бумагу, " +
                    "страница за страницей." +
                   "</p>" +
                   "<p>" +
                    "<strong>«Так что писательство — это не самодисциплина, а скорее необходимость для меня», — однажды сказала Зои Казан в " +
                    "интервью.</strong>" +
                   "</p>" +
                   "<p>" +
                    "В 2010-х годах одна из давних крупных задумок актрисы начала воплощаться на бумаге. " +
                    "Так появился фильм «Руби Спаркс» (2012), в котором Зои Казан и Пол Дано сыграли влюблённых. Любовь, правда, вышла " +
                    "«воспалённой»: из конфетно-букетного периода личная жизнь персонажей превращается в ад." +
                   "</p>" +
                   "<p>" +
                    "Одновременно с «Руби Спаркс» на больших экранах показывали трагикомедию «Дружба и никакого секса» (2013), " +
                    "съемочную площадку которой Казан делила с Дэниелом Рэдклиффом, и фильм «Близняшка» (2013), где американке " +
                    "пришлось играть сразу несколько персонажей." +
                   "</p>" +
                   "<p>" +
                    "Чуть позже вышел мистико-романтический фильм «В твоих глазах» (2014) и сериал «Что знает Оливия?», за роль в " +
                    "котором Зои Казан номинировали на «Эмми» как лучшую актрису второго плана." + 
                   "</p>" +
                   "<p>" +
                    "После «Руби Спаркс» Зои Казан и Пол Дано поняли, что вместе могут создавать шедевры. Следующая их проба оказалась " +
                    "ещё более удачной: драму «Дикая жизнь» (2018) с Джейком Джилленхолом и Кэри Маллиган в главных ролях высоко оценило " +
                    "абсолютное большинство критиков." +
                   "</p>",
                   AdditionalInfo = ""
               });
        }
    }
}
