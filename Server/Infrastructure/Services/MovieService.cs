using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using Domain;
using Infrastructure.Services.DTO;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var response = await _httpClient.GetAsync("https://copadosfilmes.azurewebsites.net/api/filmes");
            var content = await response.Content.ReadAsStringAsync();
            var moviesInfos = JsonConvert.DeserializeObject<IList<MovieDTO>>(content);

            return moviesInfos.Select(movieInfo => new Movie(
                movieInfo.id,
                movieInfo.titulo,
                movieInfo.ano,
                movieInfo.nota
            ));
        }
    }
}
