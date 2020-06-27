﻿using Entities.Models;
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
                new JobTitle { JobTitleId = 6, JobName = "композитор" });

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
                },

                new Serial
                {
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
                },

                new Serial
                {
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
                },

                new Serial
                {
                    Id = 7,
                    Name = "Звёздный путь: Пикар (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/17.jpg"
                },

                new Serial
                {
                    Id = 8,
                    Name = "Замок и ключ (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/18.jpg"
                },

                new Serial
                {
                    Id = 9,
                    Name = "Hi-Fi / Фанатик (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/19.jpg"
                },

                new Serial
                {
                    Id = 10,
                    Name = "Разрабы (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/20.jpg"
                },

                new Serial
                {
                    Id = 11,
                    Name = "Охотники (1 сезон)",
                    Rating = 5,
                    Year = 2020,
                    PosterImageSource = "StaticFiles/images/21.jpg"
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

            modelBuilder.Entity<NewsAuthor>().HasData(
                new NewsAuthor { Id = 1, FirstName = "Мария", LastName = "Колосова" },
                new NewsAuthor { Id = 2, FirstName = "Пабло", LastName = "Мироненко" },
                new NewsAuthor { Id = 3, FirstName = "Мия", LastName = "Набу" }
                );

            modelBuilder.Entity<NewsCategory>().HasData(
                new NewsCategory { Id = 1, Name = "Variety" },
                new NewsCategory { Id = 2, Name = "FilmNews" }
                );

            modelBuilder.Entity<News>().HasData(
                new News { 
                    Id = 1,
                    Title = "Сиквел «Чудо-женщины» перенесли из-за коронавируса",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                    CountViews = 233,
                    PreviewImage = "StaticFiles/images/News/1.jfif",
                    PublishTime = DateTime.Now,
                    AuthorId = 1,
                },
                new News
                {
                    Id = 2,
                    Title = "Childish Gambino официально опубликовал новый альбом",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                    CountViews = 512,
                    PreviewImage = "StaticFiles/images/News/2.jfif",
                    PublishTime = DateTime.Now,
                    AuthorId = 2,
                },
                new News
                {
                    Id = 3,
                    Title = "Больше, жестче, грубее: Вышел трейлер второго сезона «Харли Квинн»",
                    Content = "В Сети появился трейлер второго сезона анимационного сериала DС «Харли Квинн». В центре сюжета вновь окажется Харли Квинн и её команда антигероев. После того, как героиня... расстаётся с Джокером, она становится самостоятельной единицей преступного мира и наводит.Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                    CountViews = 237,
                    PreviewImage = "StaticFiles/images/News/3.jfif",
                    PublishTime = DateTime.Now,
                    AuthorId = 3,
                },
                new News
                {
                    Id = 4,
                    Title = "Фильмы онлайн: Абсолютный топ «Фильм Про»",
                    Content = "«Фильм Про» впервые обнародовал Абсолютный топ продаж российских онлайн-кинотеатров и видеосервисов. В условиях, когда из-за коронавируса домашний просмотр набирает популярность, «Фильм Про» первым среди профессиональных киноизданий ",
                    CountViews = 878,
                    PreviewImage = "StaticFiles/images/News/4.jfif",
                    PublishTime = DateTime.Now,
                    AuthorId = 1,
                });

                modelBuilder.Entity<NewsCategories>().HasData(
                new NewsCategories
                {
                    NewsId = 1,
                    CategoryId = 1
                },
                new NewsCategories
                {
                    NewsId = 2,
                    CategoryId = 2
                },
                new NewsCategories
                {
                    NewsId = 2,
                    CategoryId = 1
                },
                new NewsCategories
                {
                    NewsId = 3,
                    CategoryId = 2
                },
                new NewsCategories
                {
                    NewsId = 4,
                    CategoryId = 1
                });
        }
    }
}
