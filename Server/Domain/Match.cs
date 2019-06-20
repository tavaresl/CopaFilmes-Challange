using System;
namespace Domain
{
    public class Match
    {
        public Movie Winner { get; private set; }
        public Movie Loser { get; private set; }

        public Match(Movie movie1, Movie movie2)
        {
            if (movie1.Beats(movie2))
            {
                Winner = movie1;
                Loser = movie2;
            }
            else
            {
                Winner = movie2;
                Loser = movie1;
            }
        }
    }
}
