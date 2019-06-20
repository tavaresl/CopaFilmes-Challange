using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAll();
    }
}
