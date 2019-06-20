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
                return;
            }

            _competitors.Add(movie);
        }

        public void Start()
        {
            var currentRound = CreateFirstRound();

            while (currentRound.Count() > 1)
            {
                var newRound = new List<Match>();

                for (var i = 0; i < currentRound.Count(); i += 2)
                {
                    newRound.Add(new Match(
                        currentRound[i].Winner,
                        currentRound[i + 1].Winner
                    ));
                }

                currentRound = newRound;
            }

            Champion = currentRound.First().Winner;
            RunnerUp = currentRound.First().Loser;
        }

        private IList<Match> CreateFirstRound()
        {
            var competitors = new LinkedList<Movie>(_competitors.OrderBy(movie => movie.Title));
            var firstRound = new List<Match>();

            while (competitors.Any())
            {
                firstRound.Add(new Match(
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
