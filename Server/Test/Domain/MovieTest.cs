using System;
using Domain;
using NUnit.Framework;

namespace Test.Domain
{
    public class MovieTest
    {
        [Test]
        public void Beats_MovieHasHigherRating_ReturnsTrue()
        {
            var movie1 = new Movie("tt3606756", "Os Incríveis 2", 2018, 8.5);
            var movie2 = new Movie("tt7784604", "Hereditário", 2018, 7.8);

            Assert.IsTrue(movie1.Beats(movie2));
        }

        [Test]
        public void Beats_MovieHasLowerRating_ReturnsFalse()
        {
            var movie1 = new Movie("tt7784604", "Hereditário", 2018, 7.8);
            var movie2 = new Movie("tt3606756", "Os Incríveis 2", 2018, 8.5);

            Assert.IsFalse(movie1.Beats(movie2));
        }

        [Test]
        public void Beats_MovieHasSameRatingAndComesBefore_ReturnsTrue()
        {
            var movie1 = new Movie("tt7784604", "Hereditário", 2018, 8.5);
            var movie2 = new Movie("tt3606756", "Os Incríveis 2", 2018, 8.5);

            Assert.IsTrue(movie1.Beats(movie2));
        }
    }
}
