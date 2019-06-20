using System;
using Domain;

namespace API.Controllers.DTO
{
    public class ChampionshipDTO
    {
        public Movie Champion { get; set; }
        public Movie RunnerUp { get; set; }
    }
}
