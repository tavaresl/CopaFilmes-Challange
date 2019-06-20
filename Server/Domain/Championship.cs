using System;
using System.Linq;
using System.Collections.Generic;

namespace Domain
{
    public class Championship
    {
        private readonly IList<Movie> _competitors;

        public Movie Champion { get; private set; }
        public Movie RunnerUp { get; private set; }

        public Championship()
        {
            _competitors = new List<Movie>();
        }

        public void AddCompetitor(Movie movie)
        {
            if (_competitors.Contains(movie))
            {
                throw new Exception(@"movie {movie.Title} is already a competitor");
            }

            _competitors.Add(movie);
        }

        public void Start()
        {
            var currentRound = CreateFirstRound();

            while (currentRound.Count() > 1)
            {
                var newRound = new List<MovieMatch>();

                for (var i = 0; i < currentRound.Count(); i += 2)
                {
                    newRound.Add(new MovieMatch(
                        currentRound[i].Winner,
                        currentRound[i + 1].Winner
                    ));
                }

                currentRound = newRound;
            }

            Champion = currentRound.First().Winner;
            RunnerUp = currentRound.First().Loser;
        }

        private IList<MovieMatch> CreateFirstRound()
        {
            var competitors = new LinkedList<Movie>(_competitors.OrderBy(movie => movie.Title));
            var firstRound = new List<MovieMatch>();

            while (competitors.Any())
            {
                firstRound.Add(new MovieMatch(
                    competitors.First(),
                    competitors.Last()
                ));

                competitors.RemoveFirst();
                competitors.RemoveLast();
            }

            return firstRound;
        }
    }
}
