using System;
using NUnit.Framework;
using Domain;

namespace Test.Domain
{
    public class ChampionshipTest
    {
        [Test]
        public void AddCompetitor_MovieNotInList_ShouldAddMovieToList()
        {
            var championship = new Championship();
            var movie = new Movie("i01", "t01", 2018, 8.0);

            Assert.DoesNotThrow(() => championship.AddCompetitor(movie));
        }

        [Test]
        public void AddCompetitor_MovieAlreadyInList_ShouldThrow()
        {
            var championship = new Championship();
            var movie = new Movie("i01", "t01", 2018, 8.0);

            championship.AddCompetitor(movie);

            Assert.Throws<Exception>(() => championship.AddCompetitor(movie));
        }

        [Test]
        public void Start_GivenFourMovies_ChampionShouldBeHighestRatedMovieAfterCall()
        {
            var championship = new Championship();
            var movie1 = new Movie("i01", "t01", 2010, 2.0);
            var movie2 = new Movie("i02", "t02", 2010, 3.0);
            var movie3 = new Movie("i03", "t03", 2010, 4.0);
            var movie4 = new Movie("i04", "t04", 2010, 1.0);

            championship.AddCompetitor(movie1);
            championship.AddCompetitor(movie2);
            championship.AddCompetitor(movie3);
            championship.AddCompetitor(movie4);

            championship.Start();

            Assert.AreSame(movie3, championship.Champion); 
        }

        [Test]
        public void Start_GivenFourMovies_ChampionAndRunnerUpShouldBeNullBeforeCall()
        {
            var championship = new Championship();
            var movie1 = new Movie("i01", "t01", 2010, 2.0);
            var movie2 = new Movie("i02", "t02", 2010, 3.0);
            var movie3 = new Movie("i03", "t03", 2010, 4.0);
            var movie4 = new Movie("i04", "t04", 2010, 1.0);

            championship.AddCompetitor(movie1);
            championship.AddCompetitor(movie2);
            championship.AddCompetitor(movie3);
            championship.AddCompetitor(movie4);

            Assert.IsNull(championship.Champion);
            Assert.IsNull(championship.RunnerUp);
        }
    }
}
