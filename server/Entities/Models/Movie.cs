﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        [NotMapped]
        public ICollection<string> Countries { get; set; }
        public int DurationMinutes { get; set; }
        public int Rate { get; set; }
        public int ReleaseYear { get; set; }
        public string PosterImageSource { get; set; }
        public string Description { get; set; }
        public ICollection<MovieGenreTitles> Genres { get; set; }
        [NotMapped]
        public ICollection<string> Directors { get; set; }
        [NotMapped]
        public ICollection<string> Produsers { get; set; }
        [NotMapped]
        public ICollection<string> Writers { get; set; }
        public string ProductionDesigner { get; set; }
        public int FilmAgeRatingId { get; set; }
        public FilmAgeRating FilmAgeRating { get; set; }
        public VideoFile VideoFile { get; set; }
        [NotMapped]
        public ICollection<string> FramesImageSource { get; set; }
        public ICollection<Celebrity> Actors { get; set; }
        public ICollection<ActorsList> ActorsList { get; set; }
    }
}
