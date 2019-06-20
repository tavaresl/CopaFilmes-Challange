using System;
using NUnit.Framework;
using Domain;

namespace Test.Domain
{
    public class MovieMatchTest
    {
        [Test]
        public void Winner_MovieOneBeatsMovieTwo_IsMovieOne()
        {
            var movie1 = new Movie("i01", "t01", 2018, 8.0);
            var movie2 = new Movie("i02", "t02", 2018, 7.0);
            var match = new MovieMatch(movie1, movie2);

            Assert.AreSame(match.Winner, movie1);
            Assert.AreSame(match.Loser, movie2);
        }

        [Test]
        public void Winner_MovieOneDoesNotBeatMovieTwo_IsMovieTwo()
        {
            var movie1 = new Movie("i01", "t01", 2018, 7.0);
            var movie2 = new Movie("i02", "t02", 2018, 8.0);
            var match = new MovieMatch(movie1, movie2);

            Assert.AreSame(match.Winner, movie2);
            Assert.AreSame(match.Loser, movie1);
        }
    }
}
