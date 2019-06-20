using System;
namespace Domain
{
    public class Movie
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public int ReleaseYear { get; private set; }
        public double Rating { get; private set; }

        public Movie(string id, string title, int releaseYear, double rating)
        {
            Id = id;
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public bool Beats(Movie otherMovie)
        {
            if (this.Rating != otherMovie.Rating)
            {
                return this.Rating > otherMovie.Rating;
            }

            return string.Compare(this.Title, otherMovie.Title) > 0;
        }
    }
 }
