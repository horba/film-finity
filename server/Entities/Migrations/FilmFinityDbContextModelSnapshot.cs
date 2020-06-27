﻿// <auto-generated />
using Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(FilmFinityDbContext))]
    partial class FilmFinityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CelebrityJobTitles", b =>
                {
                    b.Property<int>("CelebrityId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.HasKey("CelebrityId", "JobTitleId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("CelebrityJobTitles");

                    b.HasData(
                        new
                        {
                            CelebrityId = -1,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -2,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -2,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -3,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -3,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -5,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -5,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -6,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -6,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 3
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -8,
                            JobTitleId = 5
                        },
                        new
                        {
                            CelebrityId = -9,
                            JobTitleId = 6
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 3
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 4
                        });
                });

            modelBuilder.Entity("Entities.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "фантастика"
                        },
                        new
                        {
                            Id = 2,
                            Name = "драма"
                        },
                        new
                        {
                            Id = 3,
                            Name = "триллер"
                        },
                        new
                        {
                            Id = 4,
                            Name = "боевик"
                        },
                        new
                        {
                            Id = 5,
                            Name = "приключения"
                        },
                        new
                        {
                            Id = 6,
                            Name = "детектив"
                        },
                        new
                        {
                            Id = 7,
                            Name = "комедия"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ужасы"
                        });
                });

            modelBuilder.Entity("Entities.Models.Serial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Serials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Видоизменённый углерод (1-2 сезон)",
                            PosterImageSource = "StaticFiles/images/11.jpg",
                            Rating = 3.0,
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            Name = "Викинги (1-6 сезон)",
                            PosterImageSource = "StaticFiles/images/12.jpg",
                            Rating = 4.0,
                            Year = 2013
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ведьмак (1 сезон)",
                            PosterImageSource = "StaticFiles/images/13.jpg",
                            Rating = 5.0,
                            Year = 2019
                        },
                        new
                        {
                            Id = 4,
                            Name = "Чужак (1 сезон)",
                            PosterImageSource = "StaticFiles/images/14.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 5,
                            Name = "Маленькая Америка (1 сезон)",
                            PosterImageSource = "StaticFiles/images/15.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 6,
                            Name = "Пятая авеню (1 сезон)",
                            PosterImageSource = "StaticFiles/images/16.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 7,
                            Name = "Звёздный путь: Пикар (1 сезон)",
                            PosterImageSource = "StaticFiles/images/17.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 8,
                            Name = "Замок и ключ (1 сезон)",
                            PosterImageSource = "StaticFiles/images/18.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 9,
                            Name = "Hi-Fi / Фанатик (1 сезон)",
                            PosterImageSource = "StaticFiles/images/19.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 10,
                            Name = "Разрабы (1 сезон)",
                            PosterImageSource = "StaticFiles/images/20.jpg",
                            Rating = 5.0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 11,
                            Name = "Охотники (1 сезон)",
                            PosterImageSource = "StaticFiles/images/21.jpg",
                            Rating = 5.0,
                            Year = 2020
                        });
                });

            modelBuilder.Entity("Entities.Models.SerialCelebrity", b =>
                {
                    b.Property<int>("SerialId")
                        .HasColumnType("int");

                    b.Property<int>("CelebrityId")
                        .HasColumnType("int");

                    b.HasKey("SerialId", "CelebrityId");

                    b.HasIndex("CelebrityId");

                    b.ToTable("SerialCelebrities");

                    b.HasData(
                        new
                        {
                            SerialId = 4,
                            CelebrityId = -1
                        },
                        new
                        {
                            SerialId = 4,
                            CelebrityId = -2
                        },
                        new
                        {
                            SerialId = 4,
                            CelebrityId = -3
                        },
                        new
                        {
                            SerialId = 5,
                            CelebrityId = -4
                        },
                        new
                        {
                            SerialId = 5,
                            CelebrityId = -5
                        },
                        new
                        {
                            SerialId = 5,
                            CelebrityId = -6
                        },
                        new
                        {
                            SerialId = 6,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 6,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 6,
                            CelebrityId = -9
                        },
                        new
                        {
                            SerialId = 7,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 7,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 7,
                            CelebrityId = -9
                        },
                        new
                        {
                            SerialId = 8,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 8,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 8,
                            CelebrityId = -9
                        },
                        new
                        {
                            SerialId = 9,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 9,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 9,
                            CelebrityId = -9
                        },
                        new
                        {
                            SerialId = 10,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 10,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 10,
                            CelebrityId = -9
                        },
                        new
                        {
                            SerialId = 11,
                            CelebrityId = -7
                        },
                        new
                        {
                            SerialId = 11,
                            CelebrityId = -8
                        },
                        new
                        {
                            SerialId = 11,
                            CelebrityId = -9
                        });
                });

            modelBuilder.Entity("Entities.Models.SerialGenreTitles", b =>
                {
                    b.Property<int>("SerialId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("SerialId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("SerialGenreTitles");

                    b.HasData(
                        new
                        {
                            SerialId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            SerialId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            SerialId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 2,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 2,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 3,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 3,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 4,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 4,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 4,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 5,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 5,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 6,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 6,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 6,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 7,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 7,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 7,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 8,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 8,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 8,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 9,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 9,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 9,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 10,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 10,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 10,
                            GenreId = 5
                        },
                        new
                        {
                            SerialId = 11,
                            GenreId = 2
                        },
                        new
                        {
                            SerialId = 11,
                            GenreId = 4
                        },
                        new
                        {
                            SerialId = 11,
                            GenreId = 5
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Celebrity", b =>
                {
                    b.Property<int>("CelebrityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountViews")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CelebrityId");

                    b.ToTable("Celebrities");

                    b.HasData(
                        new
                        {
                            CelebrityId = -1,
                            CountViews = 134000,
                            FirstName = "Хью",
                            ImageSource = "StaticFiles/images/1.jpg",
                            LastName = "Джекман"
                        },
                        new
                        {
                            CelebrityId = -2,
                            CountViews = 127000,
                            FirstName = "Райан",
                            ImageSource = "StaticFiles/images/2.jpg",
                            LastName = "Рейнольдс"
                        },
                        new
                        {
                            CelebrityId = -3,
                            CountViews = 126000,
                            FirstName = "Роберт",
                            ImageSource = "StaticFiles/images/3.jpg",
                            LastName = "Дауни (младший)"
                        },
                        new
                        {
                            CelebrityId = -4,
                            CountViews = 121000,
                            FirstName = "Уилл",
                            ImageSource = "StaticFiles/images/4.jpg",
                            LastName = "Смит"
                        },
                        new
                        {
                            CelebrityId = -5,
                            CountViews = 120500,
                            FirstName = "Брэд",
                            ImageSource = "StaticFiles/images/5.jpg",
                            LastName = "Питт"
                        },
                        new
                        {
                            CelebrityId = -6,
                            CountViews = 120000,
                            FirstName = "Леонардо",
                            ImageSource = "StaticFiles/images/6.jpg",
                            LastName = "Ди Каприо"
                        },
                        new
                        {
                            CelebrityId = -7,
                            CountViews = 91000,
                            FirstName = "Натали",
                            ImageSource = "StaticFiles/images/7.jpg",
                            LastName = "Портман"
                        },
                        new
                        {
                            CelebrityId = -8,
                            CountViews = 20000,
                            FirstName = "Роджер",
                            ImageSource = "StaticFiles/images/8.jpg",
                            LastName = "Дикинс"
                        },
                        new
                        {
                            CelebrityId = -9,
                            CountViews = 50000,
                            FirstName = "Ханс",
                            ImageSource = "StaticFiles/images/9.png",
                            LastName = "Циммер"
                        },
                        new
                        {
                            CelebrityId = -10,
                            CountViews = 95000,
                            FirstName = "Квентин",
                            ImageSource = "StaticFiles/images/10.jpg",
                            LastName = "Тарантино"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitles");

                    b.HasData(
                        new
                        {
                            JobTitleId = 1,
                            JobName = "актер"
                        },
                        new
                        {
                            JobTitleId = 2,
                            JobName = "режиссер"
                        },
                        new
                        {
                            JobTitleId = 3,
                            JobName = "сценарист"
                        },
                        new
                        {
                            JobTitleId = 4,
                            JobName = "продюсер"
                        },
                        new
                        {
                            JobTitleId = 5,
                            JobName = "оператор"
                        },
                        new
                        {
                            JobTitleId = 6,
                            JobName = "композитор"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.CelebrityJobTitles", b =>
                {
                    b.HasOne("WebAPI.Models.Celebrity", "Celebrity")
                        .WithMany("CelebrityJobTitles")
                        .HasForeignKey("CelebrityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.JobTitle", "JobTitle")
                        .WithMany("CelebrityJobTitles")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.SerialCelebrity", b =>
                {
                    b.HasOne("WebAPI.Models.Celebrity", "Celebrity")
                        .WithMany("SerialCelebrity")
                        .HasForeignKey("CelebrityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Serial", "Serial")
                        .WithMany("SerialCelebrity")
                        .HasForeignKey("SerialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.SerialGenreTitles", b =>
                {
                    b.HasOne("Entities.Models.Genre", "GenreTitle")
                        .WithMany("SerialGenreTitles")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Serial", "Serial")
                        .WithMany("SerialGenreTitles")
                        .HasForeignKey("SerialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
