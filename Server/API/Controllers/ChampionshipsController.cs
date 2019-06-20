using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.DTO;
using Domain;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ChampionshipsController : Controller
    {

        private readonly IMovieService _movieService;

        public ChampionshipsController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public async Task<ActionResult<ChampionshipDTO>> Post([FromBody]string[] moviesIds)
        {
            if (moviesIds.Length != 8)
            {
                return new BadRequestResult();
            }

            var movies = await _movieService.GetAll();
            var championship = new Championship();

            for (var i = 0; i < moviesIds.Length; i++)
            {
                var movie = movies.First(m => m.Id == moviesIds[i]);
                championship.AddCompetitor(movie);
            }

            championship.Start();

            return new ChampionshipDTO {
                Champion = championship.Champion,
                RunnerUp = championship.RunnerUp
            };
        }
    }
}
